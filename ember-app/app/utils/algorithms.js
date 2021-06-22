import Ember from 'ember';

// Структурирование данных для вычисления.
function _getObjArr(arr, sumWorkArr=0, operationsOrder=0){
  let arrWorksList = new Array();

  arr.forEach(function(item, i, arr) {
    let operationsObj = new Array();
    arr[i].forEach(function(item, i, arr) {
      operationsObj[i]={
        timeStart: 0,
        timeEnd : 0,
        time : item
      };
    });
    let curNumWork = i;
    if (operationsOrder.length > 0) {
      curNumWork = operationsOrder[i]
    }
    arrWorksList[i] = {
      numWork: curNumWork,
      operations: operationsObj,
      valueWork: sumWorkArr[i]
    };
  });

  return arrWorksList;
}

// Вычисление начала и окончания обработок в готовом плане
function _getStartEndTime(arr, m){
  let cols = arr[0].operations.length
  for(let k = 0; k < cols; k++) {
    arr.forEach((item, i, arr) => {
      let prev = new Array();
      for(let j = 0; j < k; j++)
        prev[j] = item.operations[j].timeEnd;
      
      item.operations[k].timeStart = Math.max(arr[i-1] ? arr[i-1].operations[k].timeEnd : 0, _getMaxOfArray(prev));
      item.operations[k].timeEnd = item.operations[k].timeStart + item.operations[k].time;
    });
  };

  return arr;
}

// Вычисление сумарного времени оптимального плана.
// Вызывается после _getStartEndTime
function getSumTime(arr) {
  let n = arr.length;
  let m = arr[0].operations.length;
  return arr[n-1].operations[m-1].timeEnd;
}

// Вычисление суммы операций для изделия.
function _getSumOp(arr) {
  let arrSumOp = new Array();
  
  arr.forEach(function(item, i, arr) {
    arrSumOp[i] = item.reduce(function(sum, current) {
      return sum + current;
    }, 0);
  });
  
  return arrSumOp;
}

// Наибольшее число операций
function operationsNumber(arr) {
  let arrWorks = _getSumOp(arr);
  let objArr = _getObjArr(arr, arrWorks);

  objArr.sort((a, b) => {
    if (a.valueWork < b.value_work) return -1;
    if (a.value_work > b.value_work) return 1;
    return 0;
  });

  return _getStartEndTime(objArr);
}

// Наименьшая трудоемкость
function minLabor(arr) {
  let operationsNum = new Array();
  for (let i=0; i<arr.length; i++) {

    operationsNum[i] = {
      workNum: i,
      leksString: '',
      opsArr: new Array()
    }

    arr[i].forEach((item, j, arr) => {
      operationsNum[i].opsArr[j] = {
        operation: item,
        index: j
      }
    });
    operationsNum[i].opsArr.sort((a, b) => {
      if (a.operation <= b.operation) return 1;
      if (a.operation > b.operation) return -1;
      return 0;
    });
  }

  let resultArr = new Array();
  operationsNum.forEach((item, i, arr) =>{
    resultArr.push(item.workNum);
  });

  let objArr = _getObjArr(arr);

  return _getStartEndTime(objArr);;
}

// Наибольшая трудоемкость
function maxLabor(arr) {
  let operationsNum = new Array();
  for (let i=0; i<arr.length; i++) {

    operationsNum[i] = {
      workNum: i,
      leksString: '',
      opsArr: new Array()
    }

    arr[i].forEach((item, j, arr) => {
      operationsNum[i].opsArr[j] = {
        operation: item,
        index: j
      }
    });
    operationsNum[i].opsArr.sort((a, b) => {
      if (a.operation <= b.operation) return -1;
      if (a.operation > b.operation) return 1;
      return 0;
    });
  }

  let resultArr = new Array();
  operationsNum.forEach((item, i, arr) =>{
    resultArr.push(item.workNum);
  });

  let objArr = _getObjArr(arr);

  return _getStartEndTime(objArr);;
}

// Перемещение работ согласно заданному порядку
function _replaceWorks(defaultArr, order) {
  let resultArr = new Array();
  order.forEach((item, i, arr) =>{
    resultArr.push(defaultArr[item]);
  });

  return resultArr;
};

// Случайный выбор
function randomDetail(mapList){
  for (let i = 0; i<mapList.length; i++)
      for (let j = 0; j<mapList[i].length; j++)
          if (mapList[i][j] == null)
              mapList[i].splice(j,1);
  for (let i = 0; i<mapList.length; i++)
  let randomArr = mapList[i].sort(() => Math.random() - 0.5);
  let resultArr = _replaceWorks(mapList, randomArr);
  let objArr = _getObjArr(resultArr)
  return _getStartEndTime(objArr);
}

// Алгоритм Джонсона
function jonsonAlg(defaultArr) {
  if (defaultArr.length <=2) {
    let arrTop = new Array();
    let arrBottom = new Array();
    for (let j=0; j < defaultArr.length; j++){
      if (defaultArr[j][0] <= defaultArr[j][1])
        arrTop.push(j);
      else
        arrBottom.unshift(j);
    }
    let orderArr = arrTop.concat(arrBottom);
    let resultArr = _replaceWorks(defaultArr, orderArr);
    let objArr = _getObjArr(resultArr);
  
    return _getStartEndTime(objArr);
  }
}

// Генетический алгоритм
function geneticAlgorithm(mapList){
  let mParent = new Array();
  for (let i =0; i < mapList.length; i++) {
      for (let j =0; i < mapList[i].length; j++)
          mParent.push(mapList[i][j]);
  }
  let parentPop = new Array();

  for (let i = 0; i <50; i++){
      parentPop[i] = new Array();
      for (let i = 0; i < mParent.length; i++)
          parentPop[i].push(op);
      parentPop.sort(() => Math.random() * 50);
  }
  for (let i=0; parentPop.length; i++)
    parentPop[i] = _getObjArr(parentPop[i]);
  while (parentPop.size() != 1){
    parentPop = selectionF(parentPop);
  }
  let objArr = _getObjArr(parentPop[1]);
  
  return _getStartEndTime(objArr);
}

// Функция отбора
function selectionF(parentPop){
  let selectedPop = new Array ();
  let fitValue = fitnessF(parentPop[Math.floor(Math.random() * parentPop.length)]);
  for (let i =0; i<parentPop.length; i++){
      selectedPop[i]= new Array();
      let sumDuration = 0;
      for (let j =0; j<parentPop.length; j++)
          spiciesDuration = fitnessF(parentPop[j]);
      if (sumDuration <= fitValue)
          selectedPop.push(parentPop[i]);
  }
  return crossF(selectedPop);
}

// Функция фитнеса
function fitnessF(genomeListOfspring){
  let fitValue = 0;
  let objArr = _getObjArr(genomeListOfspring);
  let timeArr = _getStartEndTime(objArr)
  let planDuration = getSumTime(timeArr);
  return planDuration;
}

// Функция скрещивания
function crossF(selectedPop){
  let offspringPop = new Array();
  for (let i =0;  i < selectedPop.length; i++)
      selectedPop.sort(() => Math.random() - 0.5); 
  let rndind =0;
  for (let i=0; i< selectedPop.length; i++) {
      rndind = Math.floor(Math.random()*selectedPop.length);
      let subList = selectedPop[rndind].slice(Math.floor(Math.random()* (selectedPop[rndind].length), Math.floor(Math.random()* (selectedPop[rndind].length))));
      let op = subList[0];
      rndind = Math.floor(Math.random()* (selectedPop.size()));
      let list = selectedPop[rndind]; 
      let index = list.indexOf(op);
      for (let i=0; i<subList.length; i++){
        let ind = list.indexOf(subList[i]);
        list = list.splice(ind, 1, 0);
      }
      list.splice(index, 0, subList);
      for (let i=0; i<subList.length; i++){
        let ind = list.indexOf(0);
        list = list.splice(ind,1);
      }
      offspringPop.push(list);
  }
  return mutationF(offspringPop);
}

// Функция генерации мутации
function mutationF(offspringPop){ 
  let rndind = 0;
  for (let i = 0; i<offspringPop.length;i++){
      let list = offspringPop[i];
      rndind1 = Math.floor(Math.random()*list.length);
      rndind2 = Math.floor(Math.random()*list.length);
      [offspringPop[i][ind1], offspringPop[i][ind2]] = [offspringPop[i][ind2], offspringPop[i][ind1]];
  }
  return offspringPop;
}

export {
  gneticAlgorithm,
  minLabor,
  maxLabor,
  randomDetail,
  operationsNumber,
  jonsonAlg,
  getSumTime
};

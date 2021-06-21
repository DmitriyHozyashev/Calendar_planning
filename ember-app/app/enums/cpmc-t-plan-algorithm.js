import { createEnum } from 'ember-flexberry-data/utils/enum-functions';

export default createEnum({
  Jonson: 'Алгоритм Джонсона',
  Genetic: 'Генетический Алгоритм',
  MinLabor: 'Наименьшая трудоемкость',
  MaxLabor: 'Наибольшая трудоемкость',
  Random: 'Случайный выбор',
  OperationNumber: 'Наибольшее число операций',
});

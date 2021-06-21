﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cpmc
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business.Audit;
    using ICSSoft.STORMNET.Business.Audit.Objects;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// ProcessOrderItem.
    /// </summary>
    // *** Start programmer edit section *** (ProcessOrderItem CustomAttributes)

    // *** End programmer edit section *** (ProcessOrderItem CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("AuditView", new string[] {
            "OrderMachine as \'Order machine\'",
            "Machine as \'Machine\'",
            "Machine.Name as \'Name\'"}, Hidden=new string[] {
            "Machine.Name"})]
    [MasterViewDefineAttribute("AuditView", "Machine", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [View("ProcessOrderItemE", new string[] {
            "OrderMachine as \'Порядок\'",
            "Machine as \'Оборудование\'",
            "Machine.Code",
            "Machine.Name as \'Наименование оборудования\'"}, Hidden=new string[] {
            "Machine.Code"})]
    [MasterViewDefineAttribute("ProcessOrderItemE", "Machine", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Code")]
    public class ProcessOrderItem : ICSSoft.STORMNET.DataObject, IDataObjectWithAuditFields
    {
        
        private int fOrderMachine;
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        private Cpmc.Machine fMachine;
        
        private Cpmc.ProcessOrder fProcessOrder;
        
        // *** Start programmer edit section *** (ProcessOrderItem CustomMembers)

        // *** End programmer edit section *** (ProcessOrderItem CustomMembers)

        
        /// <summary>
        /// OrderMachine.
        /// </summary>
        // *** Start programmer edit section *** (ProcessOrderItem.OrderMachine CustomAttributes)

        // *** End programmer edit section *** (ProcessOrderItem.OrderMachine CustomAttributes)
        public virtual int OrderMachine
        {
            get
            {
                // *** Start programmer edit section *** (ProcessOrderItem.OrderMachine Get start)

                // *** End programmer edit section *** (ProcessOrderItem.OrderMachine Get start)
                int result = this.fOrderMachine;
                // *** Start programmer edit section *** (ProcessOrderItem.OrderMachine Get end)

                // *** End programmer edit section *** (ProcessOrderItem.OrderMachine Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ProcessOrderItem.OrderMachine Set start)

                // *** End programmer edit section *** (ProcessOrderItem.OrderMachine Set start)
                this.fOrderMachine = value;
                // *** Start programmer edit section *** (ProcessOrderItem.OrderMachine Set end)

                // *** End programmer edit section *** (ProcessOrderItem.OrderMachine Set end)
            }
        }
        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        // *** Start programmer edit section *** (ProcessOrderItem.CreateTime CustomAttributes)

        // *** End programmer edit section *** (ProcessOrderItem.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                // *** Start programmer edit section *** (ProcessOrderItem.CreateTime Get start)

                // *** End programmer edit section *** (ProcessOrderItem.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                // *** Start programmer edit section *** (ProcessOrderItem.CreateTime Get end)

                // *** End programmer edit section *** (ProcessOrderItem.CreateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ProcessOrderItem.CreateTime Set start)

                // *** End programmer edit section *** (ProcessOrderItem.CreateTime Set start)
                this.fCreateTime = value;
                // *** Start programmer edit section *** (ProcessOrderItem.CreateTime Set end)

                // *** End programmer edit section *** (ProcessOrderItem.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        // *** Start programmer edit section *** (ProcessOrderItem.Creator CustomAttributes)

        // *** End programmer edit section *** (ProcessOrderItem.Creator CustomAttributes)
        [StrLen(255)]
        public virtual string Creator
        {
            get
            {
                // *** Start programmer edit section *** (ProcessOrderItem.Creator Get start)

                // *** End programmer edit section *** (ProcessOrderItem.Creator Get start)
                string result = this.fCreator;
                // *** Start programmer edit section *** (ProcessOrderItem.Creator Get end)

                // *** End programmer edit section *** (ProcessOrderItem.Creator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ProcessOrderItem.Creator Set start)

                // *** End programmer edit section *** (ProcessOrderItem.Creator Set start)
                this.fCreator = value;
                // *** Start programmer edit section *** (ProcessOrderItem.Creator Set end)

                // *** End programmer edit section *** (ProcessOrderItem.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        // *** Start programmer edit section *** (ProcessOrderItem.EditTime CustomAttributes)

        // *** End programmer edit section *** (ProcessOrderItem.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                // *** Start programmer edit section *** (ProcessOrderItem.EditTime Get start)

                // *** End programmer edit section *** (ProcessOrderItem.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                // *** Start programmer edit section *** (ProcessOrderItem.EditTime Get end)

                // *** End programmer edit section *** (ProcessOrderItem.EditTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ProcessOrderItem.EditTime Set start)

                // *** End programmer edit section *** (ProcessOrderItem.EditTime Set start)
                this.fEditTime = value;
                // *** Start programmer edit section *** (ProcessOrderItem.EditTime Set end)

                // *** End programmer edit section *** (ProcessOrderItem.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        // *** Start programmer edit section *** (ProcessOrderItem.Editor CustomAttributes)

        // *** End programmer edit section *** (ProcessOrderItem.Editor CustomAttributes)
        [StrLen(255)]
        public virtual string Editor
        {
            get
            {
                // *** Start programmer edit section *** (ProcessOrderItem.Editor Get start)

                // *** End programmer edit section *** (ProcessOrderItem.Editor Get start)
                string result = this.fEditor;
                // *** Start programmer edit section *** (ProcessOrderItem.Editor Get end)

                // *** End programmer edit section *** (ProcessOrderItem.Editor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ProcessOrderItem.Editor Set start)

                // *** End programmer edit section *** (ProcessOrderItem.Editor Set start)
                this.fEditor = value;
                // *** Start programmer edit section *** (ProcessOrderItem.Editor Set end)

                // *** End programmer edit section *** (ProcessOrderItem.Editor Set end)
            }
        }
        
        /// <summary>
        /// ProcessOrderItem.
        /// </summary>
        // *** Start programmer edit section *** (ProcessOrderItem.Machine CustomAttributes)

        // *** End programmer edit section *** (ProcessOrderItem.Machine CustomAttributes)
        [PropertyStorage(new string[] {
                "Machine"})]
        [NotNull()]
        public virtual Cpmc.Machine Machine
        {
            get
            {
                // *** Start programmer edit section *** (ProcessOrderItem.Machine Get start)

                // *** End programmer edit section *** (ProcessOrderItem.Machine Get start)
                Cpmc.Machine result = this.fMachine;
                // *** Start programmer edit section *** (ProcessOrderItem.Machine Get end)

                // *** End programmer edit section *** (ProcessOrderItem.Machine Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ProcessOrderItem.Machine Set start)

                // *** End programmer edit section *** (ProcessOrderItem.Machine Set start)
                this.fMachine = value;
                // *** Start programmer edit section *** (ProcessOrderItem.Machine Set end)

                // *** End programmer edit section *** (ProcessOrderItem.Machine Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку Cpmc.ProcessOrder.
        /// </summary>
        // *** Start programmer edit section *** (ProcessOrderItem.ProcessOrder CustomAttributes)

        // *** End programmer edit section *** (ProcessOrderItem.ProcessOrder CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "ProcessOrder"})]
        public virtual Cpmc.ProcessOrder ProcessOrder
        {
            get
            {
                // *** Start programmer edit section *** (ProcessOrderItem.ProcessOrder Get start)

                // *** End programmer edit section *** (ProcessOrderItem.ProcessOrder Get start)
                Cpmc.ProcessOrder result = this.fProcessOrder;
                // *** Start programmer edit section *** (ProcessOrderItem.ProcessOrder Get end)

                // *** End programmer edit section *** (ProcessOrderItem.ProcessOrder Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ProcessOrderItem.ProcessOrder Set start)

                // *** End programmer edit section *** (ProcessOrderItem.ProcessOrder Set start)
                this.fProcessOrder = value;
                // *** Start programmer edit section *** (ProcessOrderItem.ProcessOrder Set end)

                // *** End programmer edit section *** (ProcessOrderItem.ProcessOrder Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "AuditView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View AuditView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(Cpmc.ProcessOrderItem));
                }
            }
            
            /// <summary>
            /// "ProcessOrderItemE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ProcessOrderItemE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ProcessOrderItemE", typeof(Cpmc.ProcessOrderItem));
                }
            }
        }
        
        /// <summary>
        /// Audit class settings.
        /// </summary>
        public class AuditSettings
        {
            
            /// <summary>
            /// Включён ли аудит для класса.
            /// </summary>
            public static bool AuditEnabled = true;
            
            /// <summary>
            /// Использовать имя представления для аудита по умолчанию.
            /// </summary>
            public static bool UseDefaultView = false;
            
            /// <summary>
            /// Включён ли аудит операции чтения.
            /// </summary>
            public static bool SelectAudit = false;
            
            /// <summary>
            /// Имя представления для аудирования операции чтения.
            /// </summary>
            public static string SelectAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции создания.
            /// </summary>
            public static bool InsertAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции создания.
            /// </summary>
            public static string InsertAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции изменения.
            /// </summary>
            public static bool UpdateAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции изменения.
            /// </summary>
            public static string UpdateAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции удаления.
            /// </summary>
            public static bool DeleteAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции удаления.
            /// </summary>
            public static string DeleteAuditViewName = "AuditView";
            
            /// <summary>
            /// Путь к форме просмотра результатов аудита.
            /// </summary>
            public static string FormUrl = "";
            
            /// <summary>
            /// Режим записи данных аудита (синхронный или асинхронный).
            /// </summary>
            public static ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode WriteMode = ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode.Synchronous;
            
            /// <summary>
            /// Максимальная длина сохраняемого значения поля (если 0, то строка обрезаться не будет).
            /// </summary>
            public static int PrunningLength = 0;
            
            /// <summary>
            /// Показывать ли пользователям в изменениях первичные ключи.
            /// </summary>
            public static bool ShowPrimaryKey = false;
            
            /// <summary>
            /// Сохранять ли старое значение.
            /// </summary>
            public static bool KeepOldValue = true;
            
            /// <summary>
            /// Сжимать ли сохраняемые значения.
            /// </summary>
            public static bool Compress = false;
            
            /// <summary>
            /// Сохранять ли все значения атрибутов, а не только изменяемые.
            /// </summary>
            public static bool KeepAllValues = false;
        }
    }
    
    /// <summary>
    /// Detail array of ProcessOrderItem.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfProcessOrderItem CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfProcessOrderItem CustomAttributes)
    public class DetailArrayOfProcessOrderItem : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (Cpmc.DetailArrayOfProcessOrderItem members)

        // *** End programmer edit section *** (Cpmc.DetailArrayOfProcessOrderItem members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ProcessOrderItem by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ProcessOrderItem.
        /// </summary>
        public DetailArrayOfProcessOrderItem(Cpmc.ProcessOrder fProcessOrder) : 
                base(typeof(ProcessOrderItem), ((ICSSoft.STORMNET.DataObject)(fProcessOrder)))
        {
        }
        
        public Cpmc.ProcessOrderItem this[int index]
        {
            get
            {
                return ((Cpmc.ProcessOrderItem)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(Cpmc.ProcessOrderItem dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
//------------------------------------------------------------------------------
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
    /// Resourse.
    /// </summary>
    // *** Start programmer edit section *** (Resourse CustomAttributes)

    // *** End programmer edit section *** (Resourse CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("AuditView", new string[] {
            "Name as \'Name\'",
            "Code as \'Code\'",
            "UnitMetr as \'Unit metr\'",
            "UnitMetr.Name as \'Name\'"})]
    public class Resourse : ICSSoft.STORMNET.DataObject, IDataObjectWithAuditFields
    {
        
        private string fName;
        
        private int fCode;
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        private Cpmc.UnitMetr fUnitMetr;
        
        // *** Start programmer edit section *** (Resourse CustomMembers)

        // *** End programmer edit section *** (Resourse CustomMembers)

        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (Resourse.Name CustomAttributes)

        // *** End programmer edit section *** (Resourse.Name CustomAttributes)
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (Resourse.Name Get start)

                // *** End programmer edit section *** (Resourse.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (Resourse.Name Get end)

                // *** End programmer edit section *** (Resourse.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Resourse.Name Set start)

                // *** End programmer edit section *** (Resourse.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (Resourse.Name Set end)

                // *** End programmer edit section *** (Resourse.Name Set end)
            }
        }
        
        /// <summary>
        /// Code.
        /// </summary>
        // *** Start programmer edit section *** (Resourse.Code CustomAttributes)

        // *** End programmer edit section *** (Resourse.Code CustomAttributes)
        public virtual int Code
        {
            get
            {
                // *** Start programmer edit section *** (Resourse.Code Get start)

                // *** End programmer edit section *** (Resourse.Code Get start)
                int result = this.fCode;
                // *** Start programmer edit section *** (Resourse.Code Get end)

                // *** End programmer edit section *** (Resourse.Code Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Resourse.Code Set start)

                // *** End programmer edit section *** (Resourse.Code Set start)
                this.fCode = value;
                // *** Start programmer edit section *** (Resourse.Code Set end)

                // *** End programmer edit section *** (Resourse.Code Set end)
            }
        }
        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        // *** Start programmer edit section *** (Resourse.CreateTime CustomAttributes)

        // *** End programmer edit section *** (Resourse.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                // *** Start programmer edit section *** (Resourse.CreateTime Get start)

                // *** End programmer edit section *** (Resourse.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                // *** Start programmer edit section *** (Resourse.CreateTime Get end)

                // *** End programmer edit section *** (Resourse.CreateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Resourse.CreateTime Set start)

                // *** End programmer edit section *** (Resourse.CreateTime Set start)
                this.fCreateTime = value;
                // *** Start programmer edit section *** (Resourse.CreateTime Set end)

                // *** End programmer edit section *** (Resourse.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        // *** Start programmer edit section *** (Resourse.Creator CustomAttributes)

        // *** End programmer edit section *** (Resourse.Creator CustomAttributes)
        [StrLen(255)]
        public virtual string Creator
        {
            get
            {
                // *** Start programmer edit section *** (Resourse.Creator Get start)

                // *** End programmer edit section *** (Resourse.Creator Get start)
                string result = this.fCreator;
                // *** Start programmer edit section *** (Resourse.Creator Get end)

                // *** End programmer edit section *** (Resourse.Creator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Resourse.Creator Set start)

                // *** End programmer edit section *** (Resourse.Creator Set start)
                this.fCreator = value;
                // *** Start programmer edit section *** (Resourse.Creator Set end)

                // *** End programmer edit section *** (Resourse.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        // *** Start programmer edit section *** (Resourse.EditTime CustomAttributes)

        // *** End programmer edit section *** (Resourse.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                // *** Start programmer edit section *** (Resourse.EditTime Get start)

                // *** End programmer edit section *** (Resourse.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                // *** Start programmer edit section *** (Resourse.EditTime Get end)

                // *** End programmer edit section *** (Resourse.EditTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Resourse.EditTime Set start)

                // *** End programmer edit section *** (Resourse.EditTime Set start)
                this.fEditTime = value;
                // *** Start programmer edit section *** (Resourse.EditTime Set end)

                // *** End programmer edit section *** (Resourse.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        // *** Start programmer edit section *** (Resourse.Editor CustomAttributes)

        // *** End programmer edit section *** (Resourse.Editor CustomAttributes)
        [StrLen(255)]
        public virtual string Editor
        {
            get
            {
                // *** Start programmer edit section *** (Resourse.Editor Get start)

                // *** End programmer edit section *** (Resourse.Editor Get start)
                string result = this.fEditor;
                // *** Start programmer edit section *** (Resourse.Editor Get end)

                // *** End programmer edit section *** (Resourse.Editor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Resourse.Editor Set start)

                // *** End programmer edit section *** (Resourse.Editor Set start)
                this.fEditor = value;
                // *** Start programmer edit section *** (Resourse.Editor Set end)

                // *** End programmer edit section *** (Resourse.Editor Set end)
            }
        }
        
        /// <summary>
        /// Resourse.
        /// </summary>
        // *** Start programmer edit section *** (Resourse.UnitMetr CustomAttributes)

        // *** End programmer edit section *** (Resourse.UnitMetr CustomAttributes)
        [PropertyStorage(new string[] {
                "UnitMetr"})]
        [NotNull()]
        public virtual Cpmc.UnitMetr UnitMetr
        {
            get
            {
                // *** Start programmer edit section *** (Resourse.UnitMetr Get start)

                // *** End programmer edit section *** (Resourse.UnitMetr Get start)
                Cpmc.UnitMetr result = this.fUnitMetr;
                // *** Start programmer edit section *** (Resourse.UnitMetr Get end)

                // *** End programmer edit section *** (Resourse.UnitMetr Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Resourse.UnitMetr Set start)

                // *** End programmer edit section *** (Resourse.UnitMetr Set start)
                this.fUnitMetr = value;
                // *** Start programmer edit section *** (Resourse.UnitMetr Set end)

                // *** End programmer edit section *** (Resourse.UnitMetr Set end)
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
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(Cpmc.Resourse));
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
}

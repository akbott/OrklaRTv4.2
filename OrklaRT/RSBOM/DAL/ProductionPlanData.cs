//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductionPlanData
    {
        public int ID { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.DateTime> PlanTime { get; set; }
        public string Order { get; set; }
        public Nullable<System.DateTime> ConfirmedOrderFinishDate1 { get; set; }
        public Nullable<System.DateTime> ActualFinishDate { get; set; }
        public Nullable<System.DateTime> ScheduledFinishDate { get; set; }
        public Nullable<System.TimeSpan> ScheduledFinishTime { get; set; }
        public Nullable<System.DateTime> ActualStartDate { get; set; }
        public Nullable<System.DateTime> ScheduledStartDate { get; set; }
        public Nullable<System.TimeSpan> ScheduledStartTime { get; set; }
        public Nullable<System.DateTime> ActualFinishExecutionDate { get; set; }
        public Nullable<System.DateTime> ActualStartExecutionDate { get; set; }
        public string DeliveryCompletedIndicator { get; set; }
        public string OrderNumber { get; set; }
        public Nullable<System.DateTime> EarliestScheduledStartDate { get; set; }
        public string Language { get; set; }
        public string MixMaterialDescription { get; set; }
        public string LogicalSystem { get; set; }
        public string PlantDescription { get; set; }
        public string DeletionFlag { get; set; }
        public string OrderPriority { get; set; }
        public string ItemCategory { get; set; }
        public string WorkCenterDescription { get; set; }
        public Nullable<int> Counter { get; set; }
        public Nullable<long> ResourceObjectID { get; set; }
        public string Temp { get; set; }
        public Nullable<System.TimeSpan> EarliestScheduledStartTime { get; set; }
        public Nullable<System.DateTime> ConfirmedOrderFinishDate { get; set; }
        public Nullable<System.TimeSpan> ConfirmedOrderFinishTime { get; set; }
        public Nullable<System.TimeSpan> ActualStartTime { get; set; }
        public Nullable<System.TimeSpan> ActualStartExecutionTime { get; set; }
        public Nullable<System.TimeSpan> ActualFinishTime { get; set; }
        public string CapacityID { get; set; }
        public string MaterialDescription { get; set; }
        public string IndicatorPhase { get; set; }
        public Nullable<System.DateTime> LatestScheduledStartDate { get; set; }
        public Nullable<System.TimeSpan> LatestScheduledStartTime { get; set; }
        public string ControlKey { get; set; }
        public string Temp1 { get; set; }
        public string ShortDescription { get; set; }
        public string MixUnit { get; set; }
        public string LanguageCode { get; set; }
        public long MixMaterial { get; set; }
        public string Plant { get; set; }
        public string WorkCenter { get; set; }
        public long MaterialNumber { get; set; }
        public Nullable<double> BaseQuantity { get; set; }
        public Nullable<double> RequiredMixingQuantity { get; set; }
        public Nullable<int> ConfirmedScrap { get; set; }
        public Nullable<int> ConfirmedYield { get; set; }
        public Nullable<int> ConfirmedYield1 { get; set; }
        public Nullable<int> QuantityOfGoodsReceived { get; set; }
        public Nullable<double> ProcessingTime { get; set; }
        public Nullable<int> ScrapQuantity { get; set; }
        public double TotalOrderQuantity { get; set; }
        public int TotalScrapQuantity { get; set; }
        public string SetupTime { get; set; }
        public Nullable<double> OperationQuantity { get; set; }
        public Nullable<int> ConfirmedQuantityYield { get; set; }
        public Nullable<double> TotalStock { get; set; }
        public Nullable<double> QuantityWithdrawn { get; set; }
        public Nullable<double> SetupTid { get; set; }
        public Nullable<double> ProcTid { get; set; }
        public string CMaterialName { get; set; }
        public Nullable<double> CRemainingQuantity { get; set; }
        public Nullable<double> CRtTotal { get; set; }
        public Nullable<double> CSetup { get; set; }
        public Nullable<double> CRemainingTime { get; set; }
        public string CSequence { get; set; }
        public Nullable<System.DateTime> CStartDateH { get; set; }
        public Nullable<System.TimeSpan> CStartTimeH { get; set; }
        public string CActive { get; set; }
        public Nullable<System.DateTime> CEndDate { get; set; }
        public Nullable<System.TimeSpan> CEndTime { get; set; }
        public Nullable<System.DateTime> CStart { get; set; }
        public Nullable<System.DateTime> CStop { get; set; }
        public Nullable<System.TimeSpan> CStartSec { get; set; }
        public string CWorkCenter { get; set; }
        public Nullable<System.TimeSpan> CStopSec { get; set; }
        public Nullable<double> CAccCap { get; set; }
        public Nullable<double> CStartCap { get; set; }
        public Nullable<double> CAccCap1 { get; set; }
        public Nullable<double> CStartValue { get; set; }
        public Nullable<double> CProdValue { get; set; }
        public Nullable<double> CNowValue { get; set; }
        public Nullable<double> CTotalValue { get; set; }
        public string CAktHelp { get; set; }
        public string CAccAkt { get; set; }
        public string CAccStarted { get; set; }
        public string CLocked { get; set; }
        public Nullable<double> CCapToday { get; set; }
        public Nullable<double> CLeftNow { get; set; }
        public Nullable<System.DateTime> CCapStart { get; set; }
        public string CMixStatus { get; set; }
        public Nullable<double> CHelp2 { get; set; }
        public Nullable<double> CHelp3 { get; set; }
        public Nullable<System.DateTime> CStartDate { get; set; }
        public Nullable<System.TimeSpan> CStartTime { get; set; }
    }
}

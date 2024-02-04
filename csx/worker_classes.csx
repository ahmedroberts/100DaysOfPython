// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Address
    {
        public string lineOne { get; set; }
        public string cityName { get; set; }
        public CountrySubdivisionLevel1 countrySubdivisionLevel1 { get; set; }
        public string countryCode { get; set; }
        public string postalCode { get; set; }
    }

    public class AnnualRateAmount
    {
        public NameCode nameCode { get; set; }
        public double amountValue { get; set; }
        public string currencyCode { get; set; }
    }

    public class AssignedOrganizationalUnit
    {
        public NameCode nameCode { get; set; }
        public TypeCode typeCode { get; set; }
    }

    public class AssignmentStatus
    {
        public StatusCode statusCode { get; set; }
        public ReasonCode reasonCode { get; set; }
        public string effectiveDate { get; set; }
    }

    public class BaseRemuneration
    {
        public HourlyRateAmount hourlyRateAmount { get; set; }
        public AnnualRateAmount annualRateAmount { get; set; }
        public string effectiveDate { get; set; }
    }

    public class BusinessCommunication
    {
        public List<Email> emails { get; set; }
    }

    public class ClassificationCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
    }

    public class CodeField
    {
        public string itemID { get; set; }
        public NameCode nameCode { get; set; }
        public string codeValue { get; set; }
        public string shortName { get; set; }
    }

    public class Communication
    {
        public List<Mobile> mobiles { get; set; }
        public List<Email> emails { get; set; }
    }

    public class CountrySubdivisionLevel1
    {
        public string subdivisionType { get; set; }
        public string codeValue { get; set; }
        public string shortName { get; set; }
    }

    public class CountrySubdivisionLevel2
    {
        public string subdivisionType { get; set; }
        public string codeValue { get; set; }
        public string shortName { get; set; }
    }

    public class CoverageCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
    }

    public class CustomFieldGroup
    {
        public List<IndicatorField> indicatorFields { get; set; }
        public List<CodeField> codeFields { get; set; }
        public List<DateField> dateFields { get; set; }
        public List<StringField> stringFields { get; set; }
    }

    public class DateField
    {
        public string itemID { get; set; }
        public NameCode nameCode { get; set; }
    }

    public class DisabilityTypeCode
    {
        public string codeValue { get; set; }
        public string longName { get; set; }
    }

    public class Email
    {
        public NameCode nameCode { get; set; }
        public string emailUri { get; set; }
        public bool notificationIndicator { get; set; }
        public string itemID { get; set; }
    }

    public class EthnicityCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
    }

    public class GenderCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
    }

    public class GenderSelfIdentityCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
    }

    public class GovernmentID
    {
        public string itemID { get; set; }
        public string idValue { get; set; }
        public NameCode nameCode { get; set; }
        public string countryCode { get; set; }
    }

    public class GroupCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
    }

    public class HomeOrganizationalUnit
    {
        public NameCode nameCode { get; set; }
        public TypeCode typeCode { get; set; }
    }

    public class HomeWorkLocation
    {
        public Address address { get; set; }
        public NameCode nameCode { get; set; }
    }

    public class HourlyRateAmount
    {
        public NameCode nameCode { get; set; }
        public double amountValue { get; set; }
        public string currencyCode { get; set; }
    }

    public class IdentificationMethodCode
    {
    }

    public class IndicatorField
    {
        public string itemID { get; set; }
        public NameCode nameCode { get; set; }
        public bool indicatorValue { get; set; }
    }

    public class IndustryClassification
    {
        public NameCode nameCode { get; set; }
        public ClassificationCode classificationCode { get; set; }
    }

    public class JobCode
    {
        public string codeValue { get; set; }
        public string longName { get; set; }
    }

    public class JobFunctionCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
    }

    public class LegalAddress
    {
        public NameCode nameCode { get; set; }
        public string lineOne { get; set; }
        public string cityName { get; set; }
        public CountrySubdivisionLevel1 countrySubdivisionLevel1 { get; set; }
        public CountrySubdivisionLevel2 countrySubdivisionLevel2 { get; set; }
        public string countryCode { get; set; }
        public string postalCode { get; set; }
    }

    public class LegalName
    {
        public string givenName { get; set; }
        public string familyName1 { get; set; }
        public string formattedName { get; set; }
    }

    public class Link
    {
        public string href { get; set; }
        public string mediaType { get; set; }
        public string method { get; set; }
    }

    public class MaritalStatusCode
    {
        public string effectiveDate { get; set; }
        public string codeValue { get; set; }
    }

    public class MaximumRate
    {
        public double amountValue { get; set; }
    }

    public class MedianRate
    {
        public double amountValue { get; set; }
    }

    public class MilitaryStatusCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
    }

    public class MinimumRate
    {
        public double amountValue { get; set; }
    }

    public class Mobile
    {
        public string itemID { get; set; }
        public NameCode nameCode { get; set; }
        public string countryDialing { get; set; }
        public string areaDialing { get; set; }
        public string dialNumber { get; set; }
        public string access { get; set; }
        public string formattedNumber { get; set; }
    }

    public class NameCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
    }

    public class OccupationalClassification
    {
        public NameCode nameCode { get; set; }
        public ClassificationCode classificationCode { get; set; }
    }

    public class PayCycleCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
    }

    public class PayGradeCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
    }

    public class PayGradePayRange
    {
        public MinimumRate minimumRate { get; set; }
        public MedianRate medianRate { get; set; }
        public MaximumRate maximumRate { get; set; }
    }

    public class PayrollProcessingStatusCode
    {
        public string shortName { get; set; }
    }

    public class Person
    {
        public string birthDate { get; set; }
        public GenderCode genderCode { get; set; }
        public GenderSelfIdentityCode genderSelfIdentityCode { get; set; }
        public MaritalStatusCode maritalStatusCode { get; set; }
        public List<SocialInsuranceProgram> socialInsurancePrograms { get; set; }
        public bool disabledIndicator { get; set; }
        public List<DisabilityTypeCode> disabilityTypeCodes { get; set; }
        public PreferredName preferredName { get; set; }
        public EthnicityCode ethnicityCode { get; set; }
        public RaceCode raceCode { get; set; }
        public MilitaryStatusCode militaryStatusCode { get; set; }
        public List<object> militaryClassificationCodes { get; set; }
        public CustomFieldGroup customFieldGroup { get; set; }
        public List<GovernmentID> governmentIDs { get; set; }
        public LegalName legalName { get; set; }
        public LegalAddress legalAddress { get; set; }
        public Communication communication { get; set; }
    }

    public class Photo
    {
        public List<Link> links { get; set; }
    }

    public class PreferredName
    {
    }

    public class RaceCode
    {
        public IdentificationMethodCode identificationMethodCode { get; set; }
        public string codeValue { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
    }

    public class ReasonCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
    }

    public class ReportsTo
    {
        public string positionID { get; set; }
        public string associateOID { get; set; }
        public WorkerID workerID { get; set; }
        public ReportsToWorkerName reportsToWorkerName { get; set; }
    }

    public class ReportsToWorkerName
    {
        public string givenName { get; set; }
        public string familyName1 { get; set; }
        public string formattedName { get; set; }
    }

    public class Root
    {
        public string associateOID { get; set; }
        public WorkerID workerID { get; set; }
        public Person person { get; set; }
        public WorkerDates workerDates { get; set; }
        public WorkerStatus workerStatus { get; set; }
        public List<Photo> photos { get; set; }
        public BusinessCommunication businessCommunication { get; set; }
        public List<WorkAssignment> workAssignments { get; set; }
        public CustomFieldGroup customFieldGroup { get; set; }
    }

    public class SchemeCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
    }

    public class SocialInsuranceProgram
    {
        public NameCode nameCode { get; set; }
        public bool coveredIndicator { get; set; }
    }

    public class StandardHours
    {
        public double hoursQuantity { get; set; }
    }

    public class StatusCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
    }

    public class StringField
    {
        public string itemID { get; set; }
        public NameCode nameCode { get; set; }
        public string stringValue { get; set; }
    }

    public class TimeServiceSupervisor
    {
        public string associateOID { get; set; }
        public WorkerID workerID { get; set; }
        public ReportsToWorkerName reportsToWorkerName { get; set; }
        public string positionID { get; set; }
    }

    public class TypeCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
    }

    public class WageLawCoverage
    {
        public WageLawNameCode wageLawNameCode { get; set; }
        public CoverageCode coverageCode { get; set; }
    }

    public class WageLawNameCode
    {
        public string codeValue { get; set; }
        public string longName { get; set; }
    }

    public class WorkAssignment
    {
        public string itemID { get; set; }
        public bool primaryIndicator { get; set; }
        public string hireDate { get; set; }
        public string seniorityDate { get; set; }
        public string actualStartDate { get; set; }
        public AssignmentStatus assignmentStatus { get; set; }
        public WorkerTypeCode workerTypeCode { get; set; }
        public List<WorkerGroup> workerGroups { get; set; }
        public JobCode jobCode { get; set; }
        public string jobTitle { get; set; }
        public List<OccupationalClassification> occupationalClassifications { get; set; }
        public List<IndustryClassification> industryClassifications { get; set; }
        public WageLawCoverage wageLawCoverage { get; set; }
        public string positionID { get; set; }
        public StandardHours standardHours { get; set; }
        public double fullTimeEquivalenceRatio { get; set; }
        public List<HomeOrganizationalUnit> homeOrganizationalUnits { get; set; }
        public List<AssignedOrganizationalUnit> assignedOrganizationalUnits { get; set; }
        public HomeWorkLocation homeWorkLocation { get; set; }
        public WorkerTimeProfile workerTimeProfile { get; set; }
        public PayCycleCode payCycleCode { get; set; }
        public BaseRemuneration baseRemuneration { get; set; }
        public List<ReportsTo> reportsTo { get; set; }
        public PayrollProcessingStatusCode payrollProcessingStatusCode { get; set; }
        public string payrollGroupCode { get; set; }
        public string payrollScheduleGroupID { get; set; }
        public string payrollFileNumber { get; set; }
        public PayGradeCode payGradeCode { get; set; }
        public PayGradePayRange payGradePayRange { get; set; }
        public CustomFieldGroup customFieldGroup { get; set; }
        public bool managementPositionIndicator { get; set; }
        public JobFunctionCode jobFunctionCode { get; set; }
    }

    public class WorkerDates
    {
        public string originalHireDate { get; set; }
    }

    public class WorkerGroup
    {
        public NameCode nameCode { get; set; }
        public GroupCode groupCode { get; set; }
    }

    public class WorkerID
    {
        public string idValue { get; set; }
        public SchemeCode schemeCode { get; set; }
    }

    public class WorkerStatus
    {
        public StatusCode statusCode { get; set; }
    }

    public class WorkerTimeProfile
    {
        public bool timeAndAttendanceIndicator { get; set; }
        public string timeZoneCode { get; set; }
        public TimeServiceSupervisor timeServiceSupervisor { get; set; }
    }

    public class WorkerTypeCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
    }

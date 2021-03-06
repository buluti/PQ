//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Questionnaire.DataBroker
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuestionTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuestionTemplate()
        {
            this.AnswerTemplates = new HashSet<AnswerTemplate>();
            this.SubQuestions = new HashSet<QuestionTemplate>();
            this.Localizations = new HashSet<Localization>();
        }
    
        public int Id { get; set; }
        public string DisplayOrder { get; set; }
        public string NativeText { get; set; }
        public EQuestionType Type { get; set; }
        public int QuestionTemplateId { get; set; }
        public EAppearanceType Appearance { get; set; }
        public Nullable<int> AnswerTemplateId { get; set; }
        public int PollId { get; set; }
        public int SurveySectionId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnswerTemplate> AnswerTemplates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionTemplate> SubQuestions { get; set; }
        public virtual QuestionTemplate MasterQuestion { get; set; }
        public virtual AnswerTemplate MagicAnswer { get; set; }
        public virtual Poll Poll { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Localization> Localizations { get; set; }
        public virtual SurveySection SurveySection { get; set; }
    }
}

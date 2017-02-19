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
    
    public abstract partial class AnswerTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnswerTemplate()
        {
            this.ConditionalQuestions = new HashSet<QuestionTemplate>();
            this.Localizations = new HashSet<Localization>();
        }
    
        public int Id { get; set; }
        public EAnswerType Type { get; set; }
        public string DisplayOrder { get; set; }
        public string Text { get; set; }
        public int QuestionTemplateId { get; set; }
    
        public virtual QuestionTemplate QuestionTemplate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionTemplate> ConditionalQuestions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Localization> Localizations { get; set; }
    }
}

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
    
    public partial class SessionResult
    {
        public int Id { get; set; }
        public int VotingSessionId { get; set; }
        public int AnswerTemplateId { get; set; }
        public int QuestionTemplateId { get; set; }
    
        public virtual VotingSession VotingSession { get; set; }
        public virtual AnswerTemplate AnswerTemplate { get; set; }
        public virtual QuestionTemplate QuestionTemplate { get; set; }
    }
}

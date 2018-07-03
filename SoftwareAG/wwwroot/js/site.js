$(function () {

    let addWorkExperienceClickEvent = $('#add-workexperience').on('click', function () {
        let workExperienceId = $('#workexperiences-container .workexperience').length;

        let Html = createTemplate(workExperienceId, workExperienceTemplate)

        $('#workexperiences-container')
            .append(Html);
    });

    let addEducationClickEvent = $('#add-education').on('click', function () {
        let educationId = $('#education-container .education').length;

        let Html = createTemplate(educationId, educationTemplate)

        $('#education-container')
            .append(Html);
    });

    let addLanguageClickEvent = $('#add-language').on('click', function () {
        let languageId = $('#languages-container .language').length;

        let Html = createTemplate(languageId, languageTemplate)

        $('#languages-container')
            .append(Html);
    });

    function createTemplate(Id,template) {
        return template
            .replace(/\{\{\q_id\}\}/g, Id)
            .replace(/\{\{\q_number\}\}/g, Id + 1)
    }


    let workExperienceTemplate = `
    <div class="workexperience">
        <text>Title </text>
        <input type="text" id="WorkExperiences_{{q_id}}__Title" name="WorkExperiences[{{q_id}}].Title">
        <text>Employer </text>
        <input type="text" id="WorkExperiences_{{q_id}}__Employer" name="WorkExperiences[{{q_id}}].Employer">
        <text>Description </text>
        <input type="text" id="WorkExperiences_{{q_id}}__Description" name="WorkExperiences[{{q_id}}].Description">
        <text>Start </text>
        <input type="datetime-local" data-val="true" data-val-required="The StartDate field is required." id="WorkExperiences_{{q_id}}__StartDate" name="WorkExperiences[{{q_id}}].StartDate">
        <span class="text-danger field-validation-error" data-valmsg-for="WorkExperiences[{{q_id}}].StartDate" data-valmsg-replace="true">The value '' is invalid.</span>
        <text>End </text>
        <input type="datetime-local" data-val="true" data-val-required="The EndDate field is required." id="WorkExperiences_{{q_id}}__EndDate" name="WorkExperiences[{{q_id}}].EndDate">
        <span class="text-danger field-validation-error" data-valmsg-for="WorkExperiences[{{q_id}}].StartDate" data-valmsg-replace="true">The value '' is invalid.</span>
     </div>
    `

    let educationTemplate = `
    <div class="education">
        <text>Subject </text>
        <input type="text" id="Education_{{q_id}}__Subject" name="Education[{{q_id}}].Subject">
        <text>Institution </text>
        <input type="text" id="Education_{{q_id}}__Institution" name="Education[{{q_id}}].Institution">
        <text>Description </text>
        <input type="text" id="Education_{{q_id}}__Description" name="Education[{{q_id}}].Description">
        <text>Start </text>
        <input type="datetime-local" data-val="true" data-val-required="The StartDate field is required." id="Education_{{q_id}}__StartDate" name="Education[{{q_id}}].StartDate">
        <span class="text-danger field-validation-error" data-valmsg-for="WorkExperiences[{{q_id}}].StartDate" data-valmsg-replace="true">The value '' is invalid.</span>
        <text>End </text>
        <input type="datetime-local" data-val="true" data-val-required="The EndDate field is required." id="Education_{{q_id}}__EndDate" name="Education[{{q_id}}].EndDate">
        <span class="text-danger field-validation-error" data-valmsg-for="WorkExperiences[{{q_id}}].StartDate" data-valmsg-replace="true">The value '' is invalid.</span>
     </div>
    `

    let languageTemplate = `
    <div class="language">
        <text>Language </text>
        <input type="text" id="Languages_{{q_id}}__Name" name="Languages[{{q_id}}].Name">
        <text>Level </text>
        <input type="text" id="Languages_{{q_id}}__Level" name="Languages[{{q_id}}].Level">
        <text>Certificate </text>
        <input type="text" id="Languages_{{q_id}}__Certificate" name="Languages[{{q_id}}].Certificate">
     </div>
    `
})







Public Class RulesList

    Public Property RuleNumber() As String
    Public Property RuleDefinition() As String
End Class

Public Class SectionList

    Public Property Section() As String
    Public Property NatureOfOffenses() As String
End Class

Public Class Lists

    Friend Function List() As List(Of RulesList)
        Dim rules As New List(Of RulesList) From {
            New RulesList With {.RuleNumber = "RULE I", .RuleDefinition = "ATTENDANCE,PUNCTUALITY & DISCIPLINE"},
            New RulesList With {.RuleNumber = "RULE II", .RuleDefinition = "DISORDERLY CONDUCT/WORK BEHAVIOR"},
            New RulesList With {.RuleNumber = "RULE III", .RuleDefinition = "SECURITY, SAFETY AND PUBLIC HEALTH"},
            New RulesList With {.RuleNumber = "RULE IV", .RuleDefinition = "COMPETENCE"},
            New RulesList With {.RuleNumber = "RULE V", .RuleDefinition = "ACTS AGAINST COMPANY INTEREST OR PROPERTY"},
            New RulesList With {.RuleNumber = "RULE VI", .RuleDefinition = "MORALITY"}
        }
        Return rules
    End Function

    Friend Function Rule1Sections() As List(Of SectionList)
        Dim secLst As New List(Of SectionList) From
            {
                New SectionList With {.Section = "Section 1", .NatureOfOffenses = "Failure to register time entry 3 times in a month to the Biometric machine."},
                New SectionList With {.Section = "Section 2", .NatureOfOffenses = "Erroneous Log 3 times in a month to the Biometric machine"},
                New SectionList With {.Section = "Section 3", .NatureOfOffenses = "Incurrence of tardiness exceeding Three (3 ) instances either at reporting time or after any given break periods"},
                New SectionList With {.Section = "Section 4", .NatureOfOffenses = "Late in attending product presentation, meeting, briefing and the like without prior permission."},
                New SectionList With {.Section = "Section 5", .NatureOfOffenses = "Absent from work, failure to return for work upon expiration of leave or after rest day, failure to attend product presentation, meeting, briefing and the like without prior notice or approval from immediate superior."},
                New SectionList With {.Section = "Section 6", .NatureOfOffenses = "Unauthorized under time and overtime"},
                New SectionList With {.Section = "Section 7", .NatureOfOffenses = "Overstretching lunch and break period"},
                New SectionList With {.Section = "Section 8", .NatureOfOffenses = "Failure to follow Shifting Schedule"},
                New SectionList With {.Section = "Section 9", .NatureOfOffenses = "Reporting for work not in prescribe uniform"},
                New SectionList With {.Section = "Section 10", .NatureOfOffenses = "Non-wearing of prescribed attire for those employees who are not required to wear company uniform as prescribed in the company policy."},
                New SectionList With {.Section = "Section 11", .NatureOfOffenses = "Failing or refusing to wear the identification (ID) card upon entering and while inside the office premises"},
                New SectionList With {.Section = "Section 12", .NatureOfOffenses = "Unauthorized and improper use of the company ID card"},
                New SectionList With {.Section = "Section 13", .NatureOfOffenses = "Deliberately destroying,tampering, altering and concealing of one's or that of another's ID card"},
                New SectionList With {.Section = "Section 14", .NatureOfOffenses = "Failing to maintain proper standards or personal grooming and hygiene"},
                New SectionList With {.Section = "Section 15", .NatureOfOffenses = "Frequently receiving visitors during working hours for personal  reason or receiving and making phone calls and or texting, except  in case of emergency."},
                New SectionList With {.Section = "Section 16", .NatureOfOffenses = "Unauthorized using of headset/earphones while on duty inside the store."},
                New SectionList With {.Section = "Section 17", .NatureOfOffenses = "Intentionally tampering the biometric"},
                New SectionList With {.Section = "Section 18", .NatureOfOffenses = "Sleeping while on duty or during working hours"},
                New SectionList With {.Section = "Section 19", .NatureOfOffenses = "Sleeping while on duty causing material damage to company's property or impaired work performance."},
                New SectionList With {.Section = "Section 20", .NatureOfOffenses = "Leaving from work without permission before time-off."},
                New SectionList With {.Section = "Section 21", .NatureOfOffenses = "Habitual Tardiness, incurring Six (6) times in a month for Three (3) consecutive months within One (1) calendar year."},
                New SectionList With {.Section = "Section 22", .NatureOfOffenses = "Being reported as not at home for having a sick notice approved by the Management"},
                New SectionList With {.Section = "Section 23", .NatureOfOffenses = "Abandonment of Work (This is defined as the failure to report for work without prior notice or authorization from superior/s for 5 or more consecutive working days despite notice to report back to work within specified time.)"}
            }

        Return secLst
    End Function

    Friend Function Rule2Sections() As List(Of SectionList)
        Dim secLst As New List(Of SectionList) From
            {
                New SectionList With {.Section = "Section 24", .NatureOfOffenses = "Willfully failing to carry out verbal or written job instructions, policies and procedures or standard operating instructions issued by the immediate superior or representatives of the company."},
                New SectionList With {.Section = "Section 25", .NatureOfOffenses = "Failure to fill up/submit time keeping forms on-time (Request for DTR , Change Day Off, Leave Of Absence, Overtime Forms)."},
                New SectionList With {.Section = "Section 26", .NatureOfOffenses = "Violating directives related to proper housekeeping in the workplace like failure to maintain general cleanliness such as littering,smudging,smearing, no orderly stuffing of files,loitering in unauthorized places or otherwise violating other conditions of cleanliness and sanitation"},
                New SectionList With {.Section = "Section 27", .NatureOfOffenses = "Failure to report any violations/incident, loss or damages  within 24 hours from incident which transpired inside the store or company premises without acceptable excuse to proper authority."},
                New SectionList With {.Section = "Section 28", .NatureOfOffenses = "Failure or refusal to reply in writing the  memorandum or show cause notice  within 48hours"},
                New SectionList With {.Section = "Section 29", .NatureOfOffenses = "Late Store Opening and/or Key Management - misplaced/lost/left store keys, interchange of padlock, no proper turn-over of store keys, giving the store keys to unauthorized personnel."},
                New SectionList With {.Section = "Section 30", .NatureOfOffenses = "Engaging in horseplay, running, scuffling, throwing things, behaving roughly within company time and premises that will cause destruction of company property and/or facilities."},
                New SectionList With {.Section = "Section 31", .NatureOfOffenses = "Doing unauthorized or unofficial work during official working hours such as loafing,loitering,idle,chatting,etc."},
                New SectionList With {.Section = "Section 32", .NatureOfOffenses = "Leaving one's post without permission"},
                New SectionList With {.Section = "Section 33", .NatureOfOffenses = "Slowing down or dragging out deliberately at work"},
                New SectionList With {.Section = "Section 34", .NatureOfOffenses = "Opening,accessing or browsing any social networking site,unofficial e-mail or other similar website"},
                New SectionList With {.Section = "Section 35", .NatureOfOffenses = "Playing of computer games,or other similar activities using the computer,which are not work-related,while on duty"},
                New SectionList With {.Section = "Section 36", .NatureOfOffenses = "Downloading any file,system,application games,etc. from the Internet"},
                New SectionList With {.Section = "Section 37", .NatureOfOffenses = "Unnecessary and unauthorized Reading while on duty except reading of relevant materials directly pertaining to an employee's  work or materials provided by Management."},
                New SectionList With {.Section = "Section 38", .NatureOfOffenses = "Willfully deferring to render overtime and re assignment despite a reasonable advance notice"},
                New SectionList With {.Section = "Section 39", .NatureOfOffenses = "Obvious  discourtesy, using disrespectful, offensive language or insulting a customer, co-employee, supplier or Officers of the Company"},
                New SectionList With {.Section = "Section 40", .NatureOfOffenses = "Indecent conduct , use of profane and obscene language in addressing another person, showing or exhibiting pornographic materials on company time and premises"},
                New SectionList With {.Section = "Section 41", .NatureOfOffenses = "Borrowing of money among employees and failure to pay just debts"},
                New SectionList With {.Section = "Section 42", .NatureOfOffenses = "Selling and vending any kind of item commodity within the Company premises or soliciting benefit ticket, etc."},
                New SectionList With {.Section = "Section 43", .NatureOfOffenses = "Offering, soliciting or accepting anything of value or  soliciting gifts, favors of any kind from customers, suppliers and all other persons whom the  employee transact business with in exchange for a job, or favorable condition of employment ( work assignment, work  location, etc. ) or for personal gain."},
                New SectionList With {.Section = "Section 44", .NatureOfOffenses = "Spreading of Rumors that may cause harm and/ or inflict injury to others which will result to a damage of property"},
                New SectionList With {.Section = "Section 45", .NatureOfOffenses = "Making false or malicious statements against customers & any officer manager or any employee of the company."},
                New SectionList With {.Section = "Section 46", .NatureOfOffenses = "Other acts of insubordination where is an overt act which shows disrespect, disobedience towards superiors."},
                New SectionList With {.Section = "Section 47", .NatureOfOffenses = "Refusal to cooperate with the  company officers, branch heads or representatives of the company."},
                New SectionList With {.Section = "Section 48", .NatureOfOffenses = "Encouraging or Inducing employees to violate rules"}
            }
        Return secLst
    End Function

    Friend Function Rule3Sections() As List(Of SectionList)
        Dim secLst As New List(Of SectionList) From
            {
                New SectionList With {.Section = "Section 49", .NatureOfOffenses = "Gambling,financing, collecting or placing bets for horse racing, jai-alai, jueteng,lotteries and the like or any other form of gambling while inside the company premises."},
                New SectionList With {.Section = "Section 50", .NatureOfOffenses = "Maliciously destroying, defacing or damaging property of the company, co employees or customer"},
                New SectionList With {.Section = "Section 51", .NatureOfOffenses = "Drinking alcoholic beverage within the company premises"},
                New SectionList With {.Section = "Section 52", .NatureOfOffenses = "Smoking in restricted areas"},
                New SectionList With {.Section = "Section 53", .NatureOfOffenses = "Failing or refusing to cooperate with security protocol enforced by the Security Guard or other security systems"},
                New SectionList With {.Section = "Section 54", .NatureOfOffenses = "Entering restricted areas without authority"},
                New SectionList With {.Section = "Section 55", .NatureOfOffenses = "Assisting employees or customers to enter restricted areas without authority"},
                New SectionList With {.Section = "Section 56", .NatureOfOffenses = "Fighting or coercing a fight,injury to another,whether employee or customer,except in case  of self defense against unprovoked assault."},
                New SectionList With {.Section = "Section 57", .NatureOfOffenses = "Omission to Perform Security Procedures like not properly locking the vault door or leaving the counter door opened"},
                New SectionList With {.Section = "Section 58", .NatureOfOffenses = "Failure to undergo required medical check-up for confirmation / verification of any claim of illness."},
                New SectionList With {.Section = "Section 59", .NatureOfOffenses = "Failure to report to Company authority the fact of his contagious illness"},
                New SectionList With {.Section = "Section 60", .NatureOfOffenses = "Non-disclosure of a pending criminal offense in court and other crimes such as theft,rubbery, falsification of document and any crime showing infidelity"},
                New SectionList With {.Section = "Section 61", .NatureOfOffenses = "Possessing illegal firearms,explosives, highly combustible materials or other deadly weapons within the company premises"},
                New SectionList With {.Section = "Section 62", .NatureOfOffenses = "Pushing, selling or supplying prohibited drugs to employees or customers and possession of such prohibited material inside the company premises"},
                New SectionList With {.Section = "Section 63", .NatureOfOffenses = "Found positive for drug substance after drug test from accredited laboratory"},
                New SectionList With {.Section = "Section 64", .NatureOfOffenses = "Presentation of any forged, altered or falsified medical certificate to show good health or as justification for absence(s)"},
                New SectionList With {.Section = "Section 65", .NatureOfOffenses = "Inciting or participating in riots, or any form of disorder."},
                New SectionList With {.Section = "Section 66", .NatureOfOffenses = "Threatening or intimidating another with bodily harm or doing something illegal or immoral to the other employee or his family in connection with his job or against customers."},
                New SectionList With {.Section = "Section 67", .NatureOfOffenses = "Violating safety rules and regulations of the company"}
            }
        Return secLst
    End Function

    Friend Function Rule4Sections() As List(Of SectionList)
        Dim secLst As New List(Of SectionList) From
            {
                New SectionList With {.Section = "Section 68", .NatureOfOffenses = "Negligence in the performance of one's work or inefficiency including compliance to process, delayed completion of work assignments, failure to meet deadlines, improper discharge of instructions, inaccurate reports and the like."},
                New SectionList With {.Section = "Section 69", .NatureOfOffenses = "Gross Negligence,Causing damage or loss of documents, fixed asset, equipment, tools,and disruption of operations through gross negligence, carelessness or inefficiency. In case of considerable damage, the employee shall be required to pay for the damage in addition to the disciplinary action."},
                New SectionList With {.Section = "Section 70", .NatureOfOffenses = "Other Acts of Gross Inefficiency, Incompetence, Negligence not found in the preceding sections of this rule."}
            }
        Return secLst
    End Function

    Friend Function Rule5Sections() As List(Of SectionList)
        Dim secLst As New List(Of SectionList) From
            {
                New SectionList With {.Section = "Section 71", .NatureOfOffenses = "Using company time, materials and equipment for personal benefit."},
                New SectionList With {.Section = "Section 72", .NatureOfOffenses = "Wasting company supplies and materials"},
                New SectionList With {.Section = "Section 73", .NatureOfOffenses = "Using company vehicle without authority"},
                New SectionList With {.Section = "Section 74", .NatureOfOffenses = "Using company vehicle recklessly resulting in damage thereon or third party with authority "},
                New SectionList With {.Section = "Section 75", .NatureOfOffenses = "Misappropriating company supplies,material or equipment "},
                New SectionList With {.Section = "Section 76", .NatureOfOffenses = "Marking up of prices without authority and insurance  receipt upon the purchase of a product."},
                New SectionList With {.Section = "Section 77", .NatureOfOffenses = "Taking out any company records/documents without any authorization from the management."},
                New SectionList With {.Section = "Section 78", .NatureOfOffenses = "Removing company property from its designated place and placing the same in another place within the premises without proper written authorization from the management."},
                New SectionList With {.Section = "Section 79", .NatureOfOffenses = "Other Acts of Dishonesty where there is a clear intent of personal gain or advantage or when the dishonest act is prejudicial to the customer,co-employees and others, or when the dishonest act is patently to avoid responsibility or serious consequences."},
                New SectionList With {.Section = "Section 80", .NatureOfOffenses = "Destructing deliberately company property with the intention of wreaking havoc on the operation,paralyzing equipment, machineries and similar acts "},
                New SectionList With {.Section = "Section 81", .NatureOfOffenses = "Posting messages,comments and the like via social media that will destroy the company's image or reputation"},
                New SectionList With {.Section = "Section 82", .NatureOfOffenses = "Posting or writing unauthorized notices or removing and altering company notices"},
                New SectionList With {.Section = "Section 83", .NatureOfOffenses = "Failure or refusal to report in writing the loss of company property under his custody or accountability within 24hours"},
                New SectionList With {.Section = "Section 84", .NatureOfOffenses = "Theft of property belonging to another person or employee within Company premises."},
                New SectionList With {.Section = "Section 85", .NatureOfOffenses = "Robbery, Theft, Pilferage and Misappropriation/Failure to remit  Funds or its attempts in any form or manner from the company's merchandise/properties employees or customers."},
                New SectionList With {.Section = "Section 86", .NatureOfOffenses = "Engaging or conniving in anomalous transactions"},
                New SectionList With {.Section = "Section 87", .NatureOfOffenses = "Falsifying any document, records or information or presenting such falsified documents, records or information concerning the vouchers,receipts, inventory records, sales records, time records,application forms,any certificates or other company documents."},
                New SectionList With {.Section = "Section 88", .NatureOfOffenses = "Falsifying records or furnishing false information or committing any such acts with deliberate intent to defraud the company of cash, materials and stocks and other properties."},
                New SectionList With {.Section = "Section 89", .NatureOfOffenses = "Falsifying company receipts,forms, and other instruments with or without personal monetary gain"},
                New SectionList With {.Section = "Section 90", .NatureOfOffenses = "Forging signatures of clients or Company signatories on Company documents or falsely representing clients or Company in any documents."},
                New SectionList With {.Section = "Section 91", .NatureOfOffenses = "Any forms of dishonesty, fraud, or deceit committed by the employee against the Company or its clients or employees."},
                New SectionList With {.Section = "Section 92", .NatureOfOffenses = "Submission of fraudulent documents, misrepresentation,  omission and falsification of any kind,  ( e.g. ID, timecard, application paper, official receipt,   reports and other pertinent documents)."},
                New SectionList With {.Section = "Section 93", .NatureOfOffenses = "Betrayal of Company Trust: Unauthorized disclosure of confidential information which includes but not limited to company records, trade secrets, formula, financial operations, statements and other company documents, to the other companies or persons, competitor or not."},
                New SectionList With {.Section = "Section 94", .NatureOfOffenses = "Kickbacks: Entering into arrangements with suppliers and customers to obtain kickbacks or other preferential (advantage) treatment."},
                New SectionList With {.Section = "Section 95", .NatureOfOffenses = "Stealing company's trade secrets by taking without consent documents,records,equipmet, devices and other things which are considered highly confidential "},
                New SectionList With {.Section = "Section 96", .NatureOfOffenses = "Unauthorized possession of master keys and/or similar devices that can open stores main doors or offices."},
                New SectionList With {.Section = "Section 97", .NatureOfOffenses = "Hacking company systems and databases"},
                New SectionList With {.Section = "Section 98", .NatureOfOffenses = "Intentionally infecting company systems and databases with virus and other types of malwares"},
                New SectionList With {.Section = "Section 99", .NatureOfOffenses = "Using company name,goodwill, products and other intellectual property for personal gain, profit or deceit without the company's authority"},
                New SectionList With {.Section = "Section 100", .NatureOfOffenses = "Intentional Malversation of company funds"},
                New SectionList With {.Section = "Section 101", .NatureOfOffenses = "Collecting monetary contribution for any purpose from anyone within the company premises without authority from the management"},
                New SectionList With {.Section = "Section 102", .NatureOfOffenses = "Refusing to provide information or testify in a company investigation when he has knowledge of he acts or omissions under investigation"},
                New SectionList With {.Section = "Section 103", .NatureOfOffenses = "Deliberately giving false statements or testimonies to avoid responsibility or to distort the true facts to give undue advantage to oneself or another"},
                New SectionList With {.Section = "Section 104", .NatureOfOffenses = "Giving false testimony during company investigation"},
                New SectionList With {.Section = "Section 105", .NatureOfOffenses = "Providing false statements about himself in the company records with intent to mislead,misrepresent or conceal incriminatory information."}
            }
        Return secLst
    End Function

    Friend Function Rule6Sections() As List(Of SectionList)
        Dim secLst As New List(Of SectionList) From
            {
                New SectionList With {.Section = "Section 106", .NatureOfOffenses = "Indecent acts and utterances immoral conduct, sexual harassment, as well as grossly indecent utterances within company premises"},
                New SectionList With {.Section = "Section 107", .NatureOfOffenses = "Immoral or Unethical Practices Engaging in any immoral or unethical practices or offering services to customers or co-employees (like pimping, providing female/male companion), which are immoral or unethical in nature."},
                New SectionList With {.Section = "Section 108", .NatureOfOffenses = "Unlawful relationship (e.g. extra marital affairs)"},
                New SectionList With {.Section = "Section 109", .NatureOfOffenses = "Using company property for illegal or immoral purpose."},
                New SectionList With {.Section = "Section 110", .NatureOfOffenses = "Acts of Lasciviousness or indecent exposures within company premises or outside while on duty or in uniform. "},
                New SectionList With {.Section = "Section 111", .NatureOfOffenses = "Commission of an act pertaining to sexual harassment"},
                New SectionList With {.Section = "Section 112", .NatureOfOffenses = "Any acts of immorality"}
            }
        Return secLst
    End Function

End Class
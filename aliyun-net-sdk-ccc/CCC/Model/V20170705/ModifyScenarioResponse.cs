/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class ModifyScenarioResponse : AcsResponse
    {

        private string requestId;

        private bool? success;

        private string code;

        private string message;

        private int? httpStatusCode;

        private ModifyScenario_Scenario scenario;

        public string RequestId
        {
            get
            {
                return requestId;
            }
            set
            {
                requestId = value;
            }
        }

        public bool? Success
        {
            get
            {
                return success;
            }
            set
            {
                success = value;
            }
        }

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }

        public int? HttpStatusCode
        {
            get
            {
                return httpStatusCode;
            }
            set
            {
                httpStatusCode = value;
            }
        }

        public ModifyScenario_Scenario Scenario
        {
            get
            {
                return scenario;
            }
            set
            {
                scenario = value;
            }
        }

        public class ModifyScenario_Scenario
        {

            private string scenarioId;

            private string scenarioName;

            private string scenarioDescription;

            private string type;

            private bool? isTemplate;

            private List<ModifyScenario_Survey> surveys;

            private List<ModifyScenario_KeyValuePair> variables;

            private ModifyScenario_Strategy strategy;

            public string ScenarioId
            {
                get
                {
                    return scenarioId;
                }
                set
                {
                    scenarioId = value;
                }
            }

            public string ScenarioName
            {
                get
                {
                    return scenarioName;
                }
                set
                {
                    scenarioName = value;
                }
            }

            public string ScenarioDescription
            {
                get
                {
                    return scenarioDescription;
                }
                set
                {
                    scenarioDescription = value;
                }
            }

            public string Type
            {
                get
                {
                    return type;
                }
                set
                {
                    type = value;
                }
            }

            public bool? IsTemplate
            {
                get
                {
                    return isTemplate;
                }
                set
                {
                    isTemplate = value;
                }
            }

            public List<ModifyScenario_Survey> Surveys
            {
                get
                {
                    return surveys;
                }
                set
                {
                    surveys = value;
                }
            }

            public List<ModifyScenario_KeyValuePair> Variables
            {
                get
                {
                    return variables;
                }
                set
                {
                    variables = value;
                }
            }

            public ModifyScenario_Strategy Strategy
            {
                get
                {
                    return strategy;
                }
                set
                {
                    strategy = value;
                }
            }

            public class ModifyScenario_Survey
            {

                private string surveyId;

                private string surveyName;

                private string surveyDescription;

                private string role;

                private int? round;

                private string beebotId;

                private List<ModifyScenario_IntentNode> intents;

                public string SurveyId
                {
                    get
                    {
                        return surveyId;
                    }
                    set
                    {
                        surveyId = value;
                    }
                }

                public string SurveyName
                {
                    get
                    {
                        return surveyName;
                    }
                    set
                    {
                        surveyName = value;
                    }
                }

                public string SurveyDescription
                {
                    get
                    {
                        return surveyDescription;
                    }
                    set
                    {
                        surveyDescription = value;
                    }
                }

                public string Role
                {
                    get
                    {
                        return role;
                    }
                    set
                    {
                        role = value;
                    }
                }

                public int? Round
                {
                    get
                    {
                        return round;
                    }
                    set
                    {
                        round = value;
                    }
                }

                public string BeebotId
                {
                    get
                    {
                        return beebotId;
                    }
                    set
                    {
                        beebotId = value;
                    }
                }

                public List<ModifyScenario_IntentNode> Intents
                {
                    get
                    {
                        return intents;
                    }
                    set
                    {
                        intents = value;
                    }
                }

                public class ModifyScenario_IntentNode
                {

                    private string nodeId;

                    private string intentId;

                    public string NodeId
                    {
                        get
                        {
                            return nodeId;
                        }
                        set
                        {
                            nodeId = value;
                        }
                    }

                    public string IntentId
                    {
                        get
                        {
                            return intentId;
                        }
                        set
                        {
                            intentId = value;
                        }
                    }
                }
            }

            public class ModifyScenario_KeyValuePair
            {

                private string key;

                private string _value;

                public string Key
                {
                    get
                    {
                        return key;
                    }
                    set
                    {
                        key = value;
                    }
                }

                public string _Value
                {
                    get
                    {
                        return _value;
                    }
                    set
                    {
                        _value = value;
                    }
                }
            }

            public class ModifyScenario_Strategy
            {

                private string strategyId;

                private string strategyName;

                private string strategyDescription;

                private string type;

                private long? startTime;

                private long? endTime;

                private string repeatBy;

                private int? maxAttemptsPerDay;

                private int? minAttemptInterval;

                private string customized;

                private string routingStrategy;

                private string followUpStrategy;

                private bool? isTemplate;

                private List<ModifyScenario_TimeFrame> workingTime;

                private List<string> repeatDays;

                public string StrategyId
                {
                    get
                    {
                        return strategyId;
                    }
                    set
                    {
                        strategyId = value;
                    }
                }

                public string StrategyName
                {
                    get
                    {
                        return strategyName;
                    }
                    set
                    {
                        strategyName = value;
                    }
                }

                public string StrategyDescription
                {
                    get
                    {
                        return strategyDescription;
                    }
                    set
                    {
                        strategyDescription = value;
                    }
                }

                public string Type
                {
                    get
                    {
                        return type;
                    }
                    set
                    {
                        type = value;
                    }
                }

                public long? StartTime
                {
                    get
                    {
                        return startTime;
                    }
                    set
                    {
                        startTime = value;
                    }
                }

                public long? EndTime
                {
                    get
                    {
                        return endTime;
                    }
                    set
                    {
                        endTime = value;
                    }
                }

                public string RepeatBy
                {
                    get
                    {
                        return repeatBy;
                    }
                    set
                    {
                        repeatBy = value;
                    }
                }

                public int? MaxAttemptsPerDay
                {
                    get
                    {
                        return maxAttemptsPerDay;
                    }
                    set
                    {
                        maxAttemptsPerDay = value;
                    }
                }

                public int? MinAttemptInterval
                {
                    get
                    {
                        return minAttemptInterval;
                    }
                    set
                    {
                        minAttemptInterval = value;
                    }
                }

                public string Customized
                {
                    get
                    {
                        return customized;
                    }
                    set
                    {
                        customized = value;
                    }
                }

                public string RoutingStrategy
                {
                    get
                    {
                        return routingStrategy;
                    }
                    set
                    {
                        routingStrategy = value;
                    }
                }

                public string FollowUpStrategy
                {
                    get
                    {
                        return followUpStrategy;
                    }
                    set
                    {
                        followUpStrategy = value;
                    }
                }

                public bool? IsTemplate
                {
                    get
                    {
                        return isTemplate;
                    }
                    set
                    {
                        isTemplate = value;
                    }
                }

                public List<ModifyScenario_TimeFrame> WorkingTime
                {
                    get
                    {
                        return workingTime;
                    }
                    set
                    {
                        workingTime = value;
                    }
                }

                public List<string> RepeatDays
                {
                    get
                    {
                        return repeatDays;
                    }
                    set
                    {
                        repeatDays = value;
                    }
                }

                public class ModifyScenario_TimeFrame
                {

                    private string beginTime;

                    private string endTime;

                    public string BeginTime
                    {
                        get
                        {
                            return beginTime;
                        }
                        set
                        {
                            beginTime = value;
                        }
                    }

                    public string EndTime
                    {
                        get
                        {
                            return endTime;
                        }
                        set
                        {
                            endTime = value;
                        }
                    }
                }
            }
        }
    }
}
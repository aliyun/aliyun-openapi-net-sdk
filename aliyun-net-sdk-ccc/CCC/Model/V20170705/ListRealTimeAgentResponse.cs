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
    public class ListRealTimeAgentResponse : AcsResponse
    {

        private string requestId;

        private bool? success;

        private string code;

        private string message;

        private int? httpStatusCode;

        private List<ListRealTimeAgent_User> data;

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

        public List<ListRealTimeAgent_User> Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public class ListRealTimeAgent_User
        {

            private string ramId;

            private string displayName;

            private string phone;

            private string dn;

            private string state;

            private string stateDesc;

            private List<ListRealTimeAgent_SkillLevel> skillLevels;

            public string RamId
            {
                get
                {
                    return ramId;
                }
                set
                {
                    ramId = value;
                }
            }

            public string DisplayName
            {
                get
                {
                    return displayName;
                }
                set
                {
                    displayName = value;
                }
            }

            public string Phone
            {
                get
                {
                    return phone;
                }
                set
                {
                    phone = value;
                }
            }

            public string Dn
            {
                get
                {
                    return dn;
                }
                set
                {
                    dn = value;
                }
            }

            public string State
            {
                get
                {
                    return state;
                }
                set
                {
                    state = value;
                }
            }

            public string StateDesc
            {
                get
                {
                    return stateDesc;
                }
                set
                {
                    stateDesc = value;
                }
            }

            public List<ListRealTimeAgent_SkillLevel> SkillLevels
            {
                get
                {
                    return skillLevels;
                }
                set
                {
                    skillLevels = value;
                }
            }

            public class ListRealTimeAgent_SkillLevel
            {

                private string skillLevelId;

                private int? level;

                private ListRealTimeAgent_Skill skill;

                public string SkillLevelId
                {
                    get
                    {
                        return skillLevelId;
                    }
                    set
                    {
                        skillLevelId = value;
                    }
                }

                public int? Level
                {
                    get
                    {
                        return level;
                    }
                    set
                    {
                        level = value;
                    }
                }

                public ListRealTimeAgent_Skill Skill
                {
                    get
                    {
                        return skill;
                    }
                    set
                    {
                        skill = value;
                    }
                }

                public class ListRealTimeAgent_Skill
                {

                    private string skillGroupId;

                    private string instanceId;

                    private string skillGroupName;

                    private string skillGroupDescription;

                    public string SkillGroupId
                    {
                        get
                        {
                            return skillGroupId;
                        }
                        set
                        {
                            skillGroupId = value;
                        }
                    }

                    public string InstanceId
                    {
                        get
                        {
                            return instanceId;
                        }
                        set
                        {
                            instanceId = value;
                        }
                    }

                    public string SkillGroupName
                    {
                        get
                        {
                            return skillGroupName;
                        }
                        set
                        {
                            skillGroupName = value;
                        }
                    }

                    public string SkillGroupDescription
                    {
                        get
                        {
                            return skillGroupDescription;
                        }
                        set
                        {
                            skillGroupDescription = value;
                        }
                    }
                }
            }
        }
    }
}
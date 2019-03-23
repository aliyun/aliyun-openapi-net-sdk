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
    public class GenerateAgentStatisticReportResponse : AcsResponse
    {

        private string requestId;

        private bool? success;

        private string code;

        private string message;

        private int? httpStatusCode;

        private GenerateAgentStatisticReport_DataList dataList;

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

        public GenerateAgentStatisticReport_DataList DataList
        {
            get
            {
                return dataList;
            }
            set
            {
                dataList = value;
            }
        }

        public class GenerateAgentStatisticReport_DataList
        {

            private int? totalCount;

            private int? pageNumber;

            private int? pageSize;

            private List<GenerateAgentStatisticReport_GenerateAgentStatistic> list;

            public int? TotalCount
            {
                get
                {
                    return totalCount;
                }
                set
                {
                    totalCount = value;
                }
            }

            public int? PageNumber
            {
                get
                {
                    return pageNumber;
                }
                set
                {
                    pageNumber = value;
                }
            }

            public int? PageSize
            {
                get
                {
                    return pageSize;
                }
                set
                {
                    pageSize = value;
                }
            }

            public List<GenerateAgentStatisticReport_GenerateAgentStatistic> List
            {
                get
                {
                    return list;
                }
                set
                {
                    list = value;
                }
            }

            public class GenerateAgentStatisticReport_GenerateAgentStatistic
            {

                private string agentId;

                private string loginName;

                private string agentName;

                private string skillGroupIds;

                private string skillGroupNames;

                private string instanceId;

                private string recordDate;

                private long? totalLoggedInTime;

                private long? totalBreakTime;

                private float? occupancyRate;

                private long? totalReadyTime;

                private long? maxReadyTime;

                private long? averageReadyTime;

                private GenerateAgentStatisticReport_Inbound inbound;

                private GenerateAgentStatisticReport_Outbound outbound;

                private GenerateAgentStatisticReport_Overall overall;

                public string AgentId
                {
                    get
                    {
                        return agentId;
                    }
                    set
                    {
                        agentId = value;
                    }
                }

                public string LoginName
                {
                    get
                    {
                        return loginName;
                    }
                    set
                    {
                        loginName = value;
                    }
                }

                public string AgentName
                {
                    get
                    {
                        return agentName;
                    }
                    set
                    {
                        agentName = value;
                    }
                }

                public string SkillGroupIds
                {
                    get
                    {
                        return skillGroupIds;
                    }
                    set
                    {
                        skillGroupIds = value;
                    }
                }

                public string SkillGroupNames
                {
                    get
                    {
                        return skillGroupNames;
                    }
                    set
                    {
                        skillGroupNames = value;
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

                public string RecordDate
                {
                    get
                    {
                        return recordDate;
                    }
                    set
                    {
                        recordDate = value;
                    }
                }

                public long? TotalLoggedInTime
                {
                    get
                    {
                        return totalLoggedInTime;
                    }
                    set
                    {
                        totalLoggedInTime = value;
                    }
                }

                public long? TotalBreakTime
                {
                    get
                    {
                        return totalBreakTime;
                    }
                    set
                    {
                        totalBreakTime = value;
                    }
                }

                public float? OccupancyRate
                {
                    get
                    {
                        return occupancyRate;
                    }
                    set
                    {
                        occupancyRate = value;
                    }
                }

                public long? TotalReadyTime
                {
                    get
                    {
                        return totalReadyTime;
                    }
                    set
                    {
                        totalReadyTime = value;
                    }
                }

                public long? MaxReadyTime
                {
                    get
                    {
                        return maxReadyTime;
                    }
                    set
                    {
                        maxReadyTime = value;
                    }
                }

                public long? AverageReadyTime
                {
                    get
                    {
                        return averageReadyTime;
                    }
                    set
                    {
                        averageReadyTime = value;
                    }
                }

                public GenerateAgentStatisticReport_Inbound Inbound
                {
                    get
                    {
                        return inbound;
                    }
                    set
                    {
                        inbound = value;
                    }
                }

                public GenerateAgentStatisticReport_Outbound Outbound
                {
                    get
                    {
                        return outbound;
                    }
                    set
                    {
                        outbound = value;
                    }
                }

                public GenerateAgentStatisticReport_Overall Overall
                {
                    get
                    {
                        return overall;
                    }
                    set
                    {
                        overall = value;
                    }
                }

                public class GenerateAgentStatisticReport_Inbound
                {

                    private long? totalTalkTime;

                    private long? maxTalkTime;

                    private long? averageTalkTime;

                    private long? totalHoldTime;

                    private long? maxHoldTime;

                    private long? averageHoldTime;

                    private long? totalWorkTime;

                    private long? maxWorkTime;

                    private long? averageWorkTime;

                    private long? satisfactionSurveysOffered;

                    private long? satisfactionSurveysResponded;

                    private float? satisfactionIndex;

                    private long? callsOffered;

                    private long? callsHandled;

                    private float? handleRate;

                    private long? totalRingTime;

                    private long? maxRingTime;

                    private long? averageRingTime;

                    public long? TotalTalkTime
                    {
                        get
                        {
                            return totalTalkTime;
                        }
                        set
                        {
                            totalTalkTime = value;
                        }
                    }

                    public long? MaxTalkTime
                    {
                        get
                        {
                            return maxTalkTime;
                        }
                        set
                        {
                            maxTalkTime = value;
                        }
                    }

                    public long? AverageTalkTime
                    {
                        get
                        {
                            return averageTalkTime;
                        }
                        set
                        {
                            averageTalkTime = value;
                        }
                    }

                    public long? TotalHoldTime
                    {
                        get
                        {
                            return totalHoldTime;
                        }
                        set
                        {
                            totalHoldTime = value;
                        }
                    }

                    public long? MaxHoldTime
                    {
                        get
                        {
                            return maxHoldTime;
                        }
                        set
                        {
                            maxHoldTime = value;
                        }
                    }

                    public long? AverageHoldTime
                    {
                        get
                        {
                            return averageHoldTime;
                        }
                        set
                        {
                            averageHoldTime = value;
                        }
                    }

                    public long? TotalWorkTime
                    {
                        get
                        {
                            return totalWorkTime;
                        }
                        set
                        {
                            totalWorkTime = value;
                        }
                    }

                    public long? MaxWorkTime
                    {
                        get
                        {
                            return maxWorkTime;
                        }
                        set
                        {
                            maxWorkTime = value;
                        }
                    }

                    public long? AverageWorkTime
                    {
                        get
                        {
                            return averageWorkTime;
                        }
                        set
                        {
                            averageWorkTime = value;
                        }
                    }

                    public long? SatisfactionSurveysOffered
                    {
                        get
                        {
                            return satisfactionSurveysOffered;
                        }
                        set
                        {
                            satisfactionSurveysOffered = value;
                        }
                    }

                    public long? SatisfactionSurveysResponded
                    {
                        get
                        {
                            return satisfactionSurveysResponded;
                        }
                        set
                        {
                            satisfactionSurveysResponded = value;
                        }
                    }

                    public float? SatisfactionIndex
                    {
                        get
                        {
                            return satisfactionIndex;
                        }
                        set
                        {
                            satisfactionIndex = value;
                        }
                    }

                    public long? CallsOffered
                    {
                        get
                        {
                            return callsOffered;
                        }
                        set
                        {
                            callsOffered = value;
                        }
                    }

                    public long? CallsHandled
                    {
                        get
                        {
                            return callsHandled;
                        }
                        set
                        {
                            callsHandled = value;
                        }
                    }

                    public float? HandleRate
                    {
                        get
                        {
                            return handleRate;
                        }
                        set
                        {
                            handleRate = value;
                        }
                    }

                    public long? TotalRingTime
                    {
                        get
                        {
                            return totalRingTime;
                        }
                        set
                        {
                            totalRingTime = value;
                        }
                    }

                    public long? MaxRingTime
                    {
                        get
                        {
                            return maxRingTime;
                        }
                        set
                        {
                            maxRingTime = value;
                        }
                    }

                    public long? AverageRingTime
                    {
                        get
                        {
                            return averageRingTime;
                        }
                        set
                        {
                            averageRingTime = value;
                        }
                    }
                }

                public class GenerateAgentStatisticReport_Outbound
                {

                    private long? totalTalkTime;

                    private long? maxTalkTime;

                    private long? averageTalkTime;

                    private long? totalHoldTime;

                    private long? maxHoldTime;

                    private long? averageHoldTime;

                    private long? totalWorkTime;

                    private long? maxWorkTime;

                    private long? averageWorkTime;

                    private long? satisfactionSurveysOffered;

                    private long? satisfactionSurveysResponded;

                    private float? satisfactionIndex;

                    private long? callsDialed;

                    private long? callsAnswered;

                    private float? answerRate;

                    private long? totalDialingTime;

                    private long? totalDialingTime1;

                    private long? maxDialingTime;

                    private long? averageDialingTime;

                    public long? TotalTalkTime
                    {
                        get
                        {
                            return totalTalkTime;
                        }
                        set
                        {
                            totalTalkTime = value;
                        }
                    }

                    public long? MaxTalkTime
                    {
                        get
                        {
                            return maxTalkTime;
                        }
                        set
                        {
                            maxTalkTime = value;
                        }
                    }

                    public long? AverageTalkTime
                    {
                        get
                        {
                            return averageTalkTime;
                        }
                        set
                        {
                            averageTalkTime = value;
                        }
                    }

                    public long? TotalHoldTime
                    {
                        get
                        {
                            return totalHoldTime;
                        }
                        set
                        {
                            totalHoldTime = value;
                        }
                    }

                    public long? MaxHoldTime
                    {
                        get
                        {
                            return maxHoldTime;
                        }
                        set
                        {
                            maxHoldTime = value;
                        }
                    }

                    public long? AverageHoldTime
                    {
                        get
                        {
                            return averageHoldTime;
                        }
                        set
                        {
                            averageHoldTime = value;
                        }
                    }

                    public long? TotalWorkTime
                    {
                        get
                        {
                            return totalWorkTime;
                        }
                        set
                        {
                            totalWorkTime = value;
                        }
                    }

                    public long? MaxWorkTime
                    {
                        get
                        {
                            return maxWorkTime;
                        }
                        set
                        {
                            maxWorkTime = value;
                        }
                    }

                    public long? AverageWorkTime
                    {
                        get
                        {
                            return averageWorkTime;
                        }
                        set
                        {
                            averageWorkTime = value;
                        }
                    }

                    public long? SatisfactionSurveysOffered
                    {
                        get
                        {
                            return satisfactionSurveysOffered;
                        }
                        set
                        {
                            satisfactionSurveysOffered = value;
                        }
                    }

                    public long? SatisfactionSurveysResponded
                    {
                        get
                        {
                            return satisfactionSurveysResponded;
                        }
                        set
                        {
                            satisfactionSurveysResponded = value;
                        }
                    }

                    public float? SatisfactionIndex
                    {
                        get
                        {
                            return satisfactionIndex;
                        }
                        set
                        {
                            satisfactionIndex = value;
                        }
                    }

                    public long? CallsDialed
                    {
                        get
                        {
                            return callsDialed;
                        }
                        set
                        {
                            callsDialed = value;
                        }
                    }

                    public long? CallsAnswered
                    {
                        get
                        {
                            return callsAnswered;
                        }
                        set
                        {
                            callsAnswered = value;
                        }
                    }

                    public float? AnswerRate
                    {
                        get
                        {
                            return answerRate;
                        }
                        set
                        {
                            answerRate = value;
                        }
                    }

                    public long? TotalDialingTime
                    {
                        get
                        {
                            return totalDialingTime;
                        }
                        set
                        {
                            totalDialingTime = value;
                        }
                    }

                    public long? TotalDialingTime1
                    {
                        get
                        {
                            return totalDialingTime1;
                        }
                        set
                        {
                            totalDialingTime1 = value;
                        }
                    }

                    public long? MaxDialingTime
                    {
                        get
                        {
                            return maxDialingTime;
                        }
                        set
                        {
                            maxDialingTime = value;
                        }
                    }

                    public long? AverageDialingTime
                    {
                        get
                        {
                            return averageDialingTime;
                        }
                        set
                        {
                            averageDialingTime = value;
                        }
                    }
                }

                public class GenerateAgentStatisticReport_Overall
                {

                    private long? totalTalkTime;

                    private long? maxTalkTime;

                    private long? averageTalkTime;

                    private long? totalHoldTime;

                    private long? maxHoldTime;

                    private long? averageHoldTime;

                    private long? totalWorkTime;

                    private long? maxWorkTime;

                    private long? averageWorkTime;

                    private long? satisfactionSurveysOffered;

                    private long? satisfactionSurveysResponded;

                    private float? satisfactionIndex;

                    private long? totalCalls;

                    public long? TotalTalkTime
                    {
                        get
                        {
                            return totalTalkTime;
                        }
                        set
                        {
                            totalTalkTime = value;
                        }
                    }

                    public long? MaxTalkTime
                    {
                        get
                        {
                            return maxTalkTime;
                        }
                        set
                        {
                            maxTalkTime = value;
                        }
                    }

                    public long? AverageTalkTime
                    {
                        get
                        {
                            return averageTalkTime;
                        }
                        set
                        {
                            averageTalkTime = value;
                        }
                    }

                    public long? TotalHoldTime
                    {
                        get
                        {
                            return totalHoldTime;
                        }
                        set
                        {
                            totalHoldTime = value;
                        }
                    }

                    public long? MaxHoldTime
                    {
                        get
                        {
                            return maxHoldTime;
                        }
                        set
                        {
                            maxHoldTime = value;
                        }
                    }

                    public long? AverageHoldTime
                    {
                        get
                        {
                            return averageHoldTime;
                        }
                        set
                        {
                            averageHoldTime = value;
                        }
                    }

                    public long? TotalWorkTime
                    {
                        get
                        {
                            return totalWorkTime;
                        }
                        set
                        {
                            totalWorkTime = value;
                        }
                    }

                    public long? MaxWorkTime
                    {
                        get
                        {
                            return maxWorkTime;
                        }
                        set
                        {
                            maxWorkTime = value;
                        }
                    }

                    public long? AverageWorkTime
                    {
                        get
                        {
                            return averageWorkTime;
                        }
                        set
                        {
                            averageWorkTime = value;
                        }
                    }

                    public long? SatisfactionSurveysOffered
                    {
                        get
                        {
                            return satisfactionSurveysOffered;
                        }
                        set
                        {
                            satisfactionSurveysOffered = value;
                        }
                    }

                    public long? SatisfactionSurveysResponded
                    {
                        get
                        {
                            return satisfactionSurveysResponded;
                        }
                        set
                        {
                            satisfactionSurveysResponded = value;
                        }
                    }

                    public float? SatisfactionIndex
                    {
                        get
                        {
                            return satisfactionIndex;
                        }
                        set
                        {
                            satisfactionIndex = value;
                        }
                    }

                    public long? TotalCalls
                    {
                        get
                        {
                            return totalCalls;
                        }
                        set
                        {
                            totalCalls = value;
                        }
                    }
                }
            }
        }
    }
}
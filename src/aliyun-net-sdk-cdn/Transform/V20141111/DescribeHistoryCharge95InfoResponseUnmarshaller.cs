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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cdn.Model.V20141111;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeHistoryCharge95InfoResponseUnmarshaller
    {
        public static DescribeHistoryCharge95InfoResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeHistoryCharge95InfoResponse describeHistoryCharge95InfoResponse = new DescribeHistoryCharge95InfoResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeHistoryCharge95Info.RequestId"),
                PageNumber = context.LongValue("DescribeHistoryCharge95Info.PageNumber"),
                PageSize = context.LongValue("DescribeHistoryCharge95Info.PageSize"),
                TotalCount = context.LongValue("DescribeHistoryCharge95Info.TotalCount"),
                TotalPages = context.LongValue("DescribeHistoryCharge95Info.TotalPages"),
                UserName = context.StringValue("DescribeHistoryCharge95Info.UserName")
            };
            List<DescribeHistoryCharge95InfoResponse.HistoryCharge95Info> historyCharge95Infos = new List<DescribeHistoryCharge95InfoResponse.HistoryCharge95Info>();
			for (int i = 0; i < context.Length("DescribeHistoryCharge95Info.HistoryCharge95Infos.Length"); i++) {
                DescribeHistoryCharge95InfoResponse.HistoryCharge95Info historyCharge95Info = new DescribeHistoryCharge95InfoResponse.HistoryCharge95Info()
                {
                    DomainName = context.StringValue($"DescribeHistoryCharge95Info.HistoryCharge95Infos[{i}].DomainName"),
                    BillTime = context.StringValue($"DescribeHistoryCharge95Info.HistoryCharge95Infos[{i}].BillTime"),
                    ChargeItem = context.StringValue($"DescribeHistoryCharge95Info.HistoryCharge95Infos[{i}].ChargeItem"),
                    Max95Bps = context.LongValue($"DescribeHistoryCharge95Info.HistoryCharge95Infos[{i}].Max95Bps"),
                    Max95BpsTime = context.StringValue($"DescribeHistoryCharge95Info.HistoryCharge95Infos[{i}].Max95BpsTime"),
                    EffectiveFactor = context.FloatValue($"DescribeHistoryCharge95Info.HistoryCharge95Infos[{i}].EffectiveFactor"),
                    StartTime = context.StringValue($"DescribeHistoryCharge95Info.HistoryCharge95Infos[{i}].StartTime"),
                    EndTime = context.StringValue($"DescribeHistoryCharge95Info.HistoryCharge95Infos[{i}].EndTime"),
                    Proportion = context.FloatValue($"DescribeHistoryCharge95Info.HistoryCharge95Infos[{i}].Proportion"),
                    DownloadUrl = context.StringValue($"DescribeHistoryCharge95Info.HistoryCharge95Infos[{i}].DownloadUrl")
                };
                historyCharge95Infos.Add(historyCharge95Info);
			}
			describeHistoryCharge95InfoResponse.HistoryCharge95Infos = historyCharge95Infos;
        
			return describeHistoryCharge95InfoResponse;
        }
    }
}
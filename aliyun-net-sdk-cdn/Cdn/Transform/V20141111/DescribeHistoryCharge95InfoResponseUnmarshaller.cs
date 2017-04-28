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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeHistoryCharge95InfoResponseUnmarshaller
    {
        public static DescribeHistoryCharge95InfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeHistoryCharge95InfoResponse describeHistoryCharge95InfoResponse = new DescribeHistoryCharge95InfoResponse();

			describeHistoryCharge95InfoResponse.HttpResponse = context.HttpResponse;
			describeHistoryCharge95InfoResponse.RequestId = context.StringValue("DescribeHistoryCharge95Info.RequestId");
			describeHistoryCharge95InfoResponse.PageNumber = context.LongValue("DescribeHistoryCharge95Info.PageNumber");
			describeHistoryCharge95InfoResponse.PageSize = context.LongValue("DescribeHistoryCharge95Info.PageSize");
			describeHistoryCharge95InfoResponse.TotalCount = context.LongValue("DescribeHistoryCharge95Info.TotalCount");
			describeHistoryCharge95InfoResponse.TotalPages = context.LongValue("DescribeHistoryCharge95Info.TotalPages");
			describeHistoryCharge95InfoResponse.UserName = context.StringValue("DescribeHistoryCharge95Info.UserName");

			List<DescribeHistoryCharge95InfoResponse.HistoryCharge95Info> historyCharge95Infos = new List<DescribeHistoryCharge95InfoResponse.HistoryCharge95Info>();
			for (int i = 0; i < context.Length("DescribeHistoryCharge95Info.HistoryCharge95Infos.Length"); i++) {
				DescribeHistoryCharge95InfoResponse.HistoryCharge95Info historyCharge95Info = new DescribeHistoryCharge95InfoResponse.HistoryCharge95Info();
				historyCharge95Info.DomainName = context.StringValue("DescribeHistoryCharge95Info.HistoryCharge95Infos["+ i +"].DomainName");
				historyCharge95Info.BillTime = context.StringValue("DescribeHistoryCharge95Info.HistoryCharge95Infos["+ i +"].BillTime");
				historyCharge95Info.ChargeItem = context.StringValue("DescribeHistoryCharge95Info.HistoryCharge95Infos["+ i +"].ChargeItem");
				historyCharge95Info.Max95Bps = context.LongValue("DescribeHistoryCharge95Info.HistoryCharge95Infos["+ i +"].Max95Bps");
				historyCharge95Info.Max95BpsTime = context.StringValue("DescribeHistoryCharge95Info.HistoryCharge95Infos["+ i +"].Max95BpsTime");
				historyCharge95Info.EffectiveFactor = context.FloatValue("DescribeHistoryCharge95Info.HistoryCharge95Infos["+ i +"].EffectiveFactor");
				historyCharge95Info.StartTime = context.StringValue("DescribeHistoryCharge95Info.HistoryCharge95Infos["+ i +"].StartTime");
				historyCharge95Info.EndTime = context.StringValue("DescribeHistoryCharge95Info.HistoryCharge95Infos["+ i +"].EndTime");
				historyCharge95Info.Proportion = context.FloatValue("DescribeHistoryCharge95Info.HistoryCharge95Infos["+ i +"].Proportion");
				historyCharge95Info.DownloadUrl = context.StringValue("DescribeHistoryCharge95Info.HistoryCharge95Infos["+ i +"].DownloadUrl");

				historyCharge95Infos.Add(historyCharge95Info);
			}
			describeHistoryCharge95InfoResponse.HistoryCharge95Infos = historyCharge95Infos;
        
			return describeHistoryCharge95InfoResponse;
        }
    }
}
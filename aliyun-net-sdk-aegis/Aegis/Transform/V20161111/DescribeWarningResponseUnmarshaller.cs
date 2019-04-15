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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeWarningResponseUnmarshaller
    {
        public static DescribeWarningResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeWarningResponse describeWarningResponse = new DescribeWarningResponse();

			describeWarningResponse.HttpResponse = context.HttpResponse;
			describeWarningResponse.RequestId = context.StringValue("DescribeWarning.RequestId");
			describeWarningResponse.Count = context.IntegerValue("DescribeWarning.Count");
			describeWarningResponse.PageSize = context.IntegerValue("DescribeWarning.PageSize");
			describeWarningResponse.TotalCount = context.IntegerValue("DescribeWarning.TotalCount");
			describeWarningResponse.CurrentPage = context.IntegerValue("DescribeWarning.CurrentPage");

			List<DescribeWarningResponse.DescribeWarning_Warning> describeWarningResponse_warnings = new List<DescribeWarningResponse.DescribeWarning_Warning>();
			for (int i = 0; i < context.Length("DescribeWarning.Warnings.Length"); i++) {
				DescribeWarningResponse.DescribeWarning_Warning warning = new DescribeWarningResponse.DescribeWarning_Warning();
				warning.RiskWarningId = context.LongValue("DescribeWarning.Warnings["+ i +"].RiskWarningId");
				warning.RiskName = context.StringValue("DescribeWarning.Warnings["+ i +"].RiskName");
				warning.Uuid = context.StringValue("DescribeWarning.Warnings["+ i +"].Uuid");
				warning.RirstFoundTime = context.StringValue("DescribeWarning.Warnings["+ i +"].RirstFoundTime");
				warning.LastFoundTime = context.StringValue("DescribeWarning.Warnings["+ i +"].LastFoundTime");
				warning.Level = context.StringValue("DescribeWarning.Warnings["+ i +"].Level");
				warning.TypeName = context.StringValue("DescribeWarning.Warnings["+ i +"].TypeName");
				warning.SubTypeName = context.StringValue("DescribeWarning.Warnings["+ i +"].SubTypeName");
				warning.TypeAlias = context.StringValue("DescribeWarning.Warnings["+ i +"].TypeAlias");
				warning.SubTypeAlias = context.StringValue("DescribeWarning.Warnings["+ i +"].SubTypeAlias");
				warning.Status = context.IntegerValue("DescribeWarning.Warnings["+ i +"].Status");

				List<DescribeWarningResponse.DescribeWarning_Warning.DescribeWarning_Detail> warning_details = new List<DescribeWarningResponse.DescribeWarning_Warning.DescribeWarning_Detail>();
				for (int j = 0; j < context.Length("DescribeWarning.Warnings["+ i +"].Details.Length"); j++) {
					DescribeWarningResponse.DescribeWarning_Warning.DescribeWarning_Detail detail = new DescribeWarningResponse.DescribeWarning_Warning.DescribeWarning_Detail();

					List<DescribeWarningResponse.DescribeWarning_Warning.DescribeWarning_Detail.DescribeWarning_DetailItem> detail_detailItems = new List<DescribeWarningResponse.DescribeWarning_Warning.DescribeWarning_Detail.DescribeWarning_DetailItem>();
					for (int k = 0; k < context.Length("DescribeWarning.Warnings["+ i +"].Details["+ j +"].DetailItems.Length"); k++) {
						DescribeWarningResponse.DescribeWarning_Warning.DescribeWarning_Detail.DescribeWarning_DetailItem detailItem = new DescribeWarningResponse.DescribeWarning_Warning.DescribeWarning_Detail.DescribeWarning_DetailItem();
						detailItem.Name = context.StringValue("DescribeWarning.Warnings["+ i +"].Details["+ j +"].DetailItems["+ k +"].Name");
						detailItem._Value = context.StringValue("DescribeWarning.Warnings["+ i +"].Details["+ j +"].DetailItems["+ k +"].Value");
						detailItem.Type = context.StringValue("DescribeWarning.Warnings["+ i +"].Details["+ j +"].DetailItems["+ k +"].Type");

						detail_detailItems.Add(detailItem);
					}
					detail.DetailItems = detail_detailItems;

					warning_details.Add(detail);
				}
				warning.Details = warning_details;

				describeWarningResponse_warnings.Add(warning);
			}
			describeWarningResponse.Warnings = describeWarningResponse_warnings;
        
			return describeWarningResponse;
        }
    }
}

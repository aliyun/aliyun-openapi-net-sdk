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
using Aliyun.Acs.Rds.Model.V20140815;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeAbnormalDBInstancesResponseUnmarshaller
    {
        public static DescribeAbnormalDBInstancesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeAbnormalDBInstancesResponse describeAbnormalDBInstancesResponse = new DescribeAbnormalDBInstancesResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeAbnormalDBInstances.RequestId"),
                TotalRecordCount = context.IntegerValue("DescribeAbnormalDBInstances.TotalRecordCount"),
                PageNumber = context.IntegerValue("DescribeAbnormalDBInstances.PageNumber"),
                PageRecordCount = context.IntegerValue("DescribeAbnormalDBInstances.PageRecordCount")
            };
            List<DescribeAbnormalDBInstancesResponse.InstanceResult> items = new List<DescribeAbnormalDBInstancesResponse.InstanceResult>();
			for (int i = 0; i < context.Length("DescribeAbnormalDBInstances.Items.Length"); i++) {
                DescribeAbnormalDBInstancesResponse.InstanceResult instanceResult = new DescribeAbnormalDBInstancesResponse.InstanceResult()
                {
                    DBInstanceDescription = context.StringValue($"DescribeAbnormalDBInstances.Items[{i}].DBInstanceDescription"),
                    DBInstanceId = context.StringValue($"DescribeAbnormalDBInstances.Items[{i}].DBInstanceId")
                };
                List<DescribeAbnormalDBInstancesResponse.InstanceResult.AbnormalItem> abnormalItems = new List<DescribeAbnormalDBInstancesResponse.InstanceResult.AbnormalItem>();
				for (int j = 0; j < context.Length($"DescribeAbnormalDBInstances.Items[{i}].AbnormalItems.Length"); j++) {
                    DescribeAbnormalDBInstancesResponse.InstanceResult.AbnormalItem abnormalItem = new DescribeAbnormalDBInstancesResponse.InstanceResult.AbnormalItem()
                    {
                        CheckTime = context.StringValue($"DescribeAbnormalDBInstances.Items[{i}].AbnormalItems[{j}].CheckTime"),
                        CheckItem = context.StringValue($"DescribeAbnormalDBInstances.Items[{i}].AbnormalItems[{j}].CheckItem"),
                        AbnormalReason = context.StringValue($"DescribeAbnormalDBInstances.Items[{i}].AbnormalItems[{j}].AbnormalReason"),
                        AbnormalValue = context.StringValue($"DescribeAbnormalDBInstances.Items[{i}].AbnormalItems[{j}].AbnormalValue"),
                        AbnormalDetail = context.StringValue($"DescribeAbnormalDBInstances.Items[{i}].AbnormalItems[{j}].AbnormalDetail"),
                        AdviceKey = context.StringValue($"DescribeAbnormalDBInstances.Items[{i}].AbnormalItems[{j}].AdviceKey")
                    };
                    List<string> adviseValue = new List<string>();
					for (int k = 0; k < context.Length($"DescribeAbnormalDBInstances.Items[{i}].AbnormalItems[{j}].AdviseValue.Length"); k++) {
						adviseValue.Add(context.StringValue($"DescribeAbnormalDBInstances.Items[{i}].AbnormalItems[{j}].AdviseValue["+ k +"]"));
					}
					abnormalItem.AdviseValue = adviseValue;

					abnormalItems.Add(abnormalItem);
				}
				instanceResult.AbnormalItems = abnormalItems;

				items.Add(instanceResult);
			}
			describeAbnormalDBInstancesResponse.Items = items;
        
			return describeAbnormalDBInstancesResponse;
        }
    }
}
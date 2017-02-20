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
    public class DescribeOptimizeAdviceOnStorageResponseUnmarshaller
    {
        public static DescribeOptimizeAdviceOnStorageResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeOptimizeAdviceOnStorageResponse describeOptimizeAdviceOnStorageResponse = new DescribeOptimizeAdviceOnStorageResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeOptimizeAdviceOnStorage.RequestId"),
                DBInstanceId = context.StringValue("DescribeOptimizeAdviceOnStorage.DBInstanceId"),
                TotalRecordsCount = context.IntegerValue("DescribeOptimizeAdviceOnStorage.TotalRecordsCount"),
                PageNumber = context.IntegerValue("DescribeOptimizeAdviceOnStorage.PageNumber"),
                PageRecordCount = context.IntegerValue("DescribeOptimizeAdviceOnStorage.PageRecordCount")
            };
            List<DescribeOptimizeAdviceOnStorageResponse.AdviceOnStorage> items = new List<DescribeOptimizeAdviceOnStorageResponse.AdviceOnStorage>();
			for (int i = 0; i < context.Length("DescribeOptimizeAdviceOnStorage.Items.Length"); i++) {
                DescribeOptimizeAdviceOnStorageResponse.AdviceOnStorage adviceOnStorage = new DescribeOptimizeAdviceOnStorageResponse.AdviceOnStorage()
                {
                    DBName = context.StringValue($"DescribeOptimizeAdviceOnStorage.Items[{i}].DBName"),
                    TableName = context.StringValue($"DescribeOptimizeAdviceOnStorage.Items[{i}].TableName"),
                    CurrentEngine = context.StringValue($"DescribeOptimizeAdviceOnStorage.Items[{i}].CurrentEngine"),
                    AdviseEngine = context.StringValue($"DescribeOptimizeAdviceOnStorage.Items[{i}].AdviseEngine")
                };
                items.Add(adviceOnStorage);
			}
			describeOptimizeAdviceOnStorageResponse.Items = items;
        
			return describeOptimizeAdviceOnStorageResponse;
        }
    }
}
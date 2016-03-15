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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeOptimizeAdviceOnExcessIndexResponseUnmarshaller
    {
        public static DescribeOptimizeAdviceOnExcessIndexResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOptimizeAdviceOnExcessIndexResponse describeOptimizeAdviceOnExcessIndexResponse = new DescribeOptimizeAdviceOnExcessIndexResponse();

			describeOptimizeAdviceOnExcessIndexResponse.HttpResponse = context.HttpResponse;
			describeOptimizeAdviceOnExcessIndexResponse.RequestId = context.StringValue("DescribeOptimizeAdviceOnExcessIndex.RequestId");
			describeOptimizeAdviceOnExcessIndexResponse.TotalRecordsCount = context.IntegerValue("DescribeOptimizeAdviceOnExcessIndex.TotalRecordsCount");
			describeOptimizeAdviceOnExcessIndexResponse.PageNumber = context.IntegerValue("DescribeOptimizeAdviceOnExcessIndex.PageNumber");
			describeOptimizeAdviceOnExcessIndexResponse.PageRecordCount = context.IntegerValue("DescribeOptimizeAdviceOnExcessIndex.PageRecordCount");

			List<DescribeOptimizeAdviceOnExcessIndexResponse.AdviceOnExcessIndex> items = new List<DescribeOptimizeAdviceOnExcessIndexResponse.AdviceOnExcessIndex>();
			for (int i = 0; i < context.Length("DescribeOptimizeAdviceOnExcessIndex.Items.Length"); i++) {
				DescribeOptimizeAdviceOnExcessIndexResponse.AdviceOnExcessIndex adviceOnExcessIndex = new DescribeOptimizeAdviceOnExcessIndexResponse.AdviceOnExcessIndex();
				adviceOnExcessIndex.DBName = context.StringValue("DescribeOptimizeAdviceOnExcessIndex.Items["+ i +"].DBName");
				adviceOnExcessIndex.TableName = context.StringValue("DescribeOptimizeAdviceOnExcessIndex.Items["+ i +"].TableName");
				adviceOnExcessIndex.IndexCount = context.LongValue("DescribeOptimizeAdviceOnExcessIndex.Items["+ i +"].IndexCount");

				items.Add(adviceOnExcessIndex);
			}
			describeOptimizeAdviceOnExcessIndexResponse.Items = items;
        
			return describeOptimizeAdviceOnExcessIndexResponse;
        }
    }
}
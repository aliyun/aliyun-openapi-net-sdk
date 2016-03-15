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
    public class DescribeOptimizeAdviceOnBigTableResponseUnmarshaller
    {
        public static DescribeOptimizeAdviceOnBigTableResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOptimizeAdviceOnBigTableResponse describeOptimizeAdviceOnBigTableResponse = new DescribeOptimizeAdviceOnBigTableResponse();

			describeOptimizeAdviceOnBigTableResponse.HttpResponse = context.HttpResponse;
			describeOptimizeAdviceOnBigTableResponse.RequestId = context.StringValue("DescribeOptimizeAdviceOnBigTable.RequestId");
			describeOptimizeAdviceOnBigTableResponse.TotalRecordsCount = context.IntegerValue("DescribeOptimizeAdviceOnBigTable.TotalRecordsCount");
			describeOptimizeAdviceOnBigTableResponse.PageNumber = context.IntegerValue("DescribeOptimizeAdviceOnBigTable.PageNumber");
			describeOptimizeAdviceOnBigTableResponse.PageRecordCount = context.IntegerValue("DescribeOptimizeAdviceOnBigTable.PageRecordCount");

			List<DescribeOptimizeAdviceOnBigTableResponse.AdviceOnBigTable> items = new List<DescribeOptimizeAdviceOnBigTableResponse.AdviceOnBigTable>();
			for (int i = 0; i < context.Length("DescribeOptimizeAdviceOnBigTable.Items.Length"); i++) {
				DescribeOptimizeAdviceOnBigTableResponse.AdviceOnBigTable adviceOnBigTable = new DescribeOptimizeAdviceOnBigTableResponse.AdviceOnBigTable();
				adviceOnBigTable.DBName = context.StringValue("DescribeOptimizeAdviceOnBigTable.Items["+ i +"].DBName");
				adviceOnBigTable.TableName = context.StringValue("DescribeOptimizeAdviceOnBigTable.Items["+ i +"].TableName");
				adviceOnBigTable.TableSize = context.LongValue("DescribeOptimizeAdviceOnBigTable.Items["+ i +"].TableSize");
				adviceOnBigTable.DataSize = context.LongValue("DescribeOptimizeAdviceOnBigTable.Items["+ i +"].DataSize");
				adviceOnBigTable.IndexSize = context.LongValue("DescribeOptimizeAdviceOnBigTable.Items["+ i +"].IndexSize");

				items.Add(adviceOnBigTable);
			}
			describeOptimizeAdviceOnBigTableResponse.Items = items;
        
			return describeOptimizeAdviceOnBigTableResponse;
        }
    }
}
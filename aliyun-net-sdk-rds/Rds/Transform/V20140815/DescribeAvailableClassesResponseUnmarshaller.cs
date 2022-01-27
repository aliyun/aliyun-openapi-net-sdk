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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeAvailableClassesResponseUnmarshaller
    {
        public static DescribeAvailableClassesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableClassesResponse describeAvailableClassesResponse = new DescribeAvailableClassesResponse();

			describeAvailableClassesResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableClassesResponse.RequestId = _ctx.StringValue("DescribeAvailableClasses.RequestId");

			List<DescribeAvailableClassesResponse.DescribeAvailableClasses_DBInstanceClass> describeAvailableClassesResponse_dBInstanceClasses = new List<DescribeAvailableClassesResponse.DescribeAvailableClasses_DBInstanceClass>();
			for (int i = 0; i < _ctx.Length("DescribeAvailableClasses.DBInstanceClasses.Length"); i++) {
				DescribeAvailableClassesResponse.DescribeAvailableClasses_DBInstanceClass dBInstanceClass = new DescribeAvailableClassesResponse.DescribeAvailableClasses_DBInstanceClass();
				dBInstanceClass.DBInstanceClass = _ctx.StringValue("DescribeAvailableClasses.DBInstanceClasses["+ i +"].DBInstanceClass");
				dBInstanceClass.StorageRange = _ctx.StringValue("DescribeAvailableClasses.DBInstanceClasses["+ i +"].StorageRange");

				DescribeAvailableClassesResponse.DescribeAvailableClasses_DBInstanceClass.DescribeAvailableClasses_DBInstanceStorageRange dBInstanceStorageRange = new DescribeAvailableClassesResponse.DescribeAvailableClasses_DBInstanceClass.DescribeAvailableClasses_DBInstanceStorageRange();
				dBInstanceStorageRange.MaxValue = _ctx.IntegerValue("DescribeAvailableClasses.DBInstanceClasses["+ i +"].DBInstanceStorageRange.MaxValue");
				dBInstanceStorageRange.MinValue = _ctx.IntegerValue("DescribeAvailableClasses.DBInstanceClasses["+ i +"].DBInstanceStorageRange.MinValue");
				dBInstanceStorageRange.Step = _ctx.IntegerValue("DescribeAvailableClasses.DBInstanceClasses["+ i +"].DBInstanceStorageRange.Step");
				dBInstanceClass.DBInstanceStorageRange = dBInstanceStorageRange;

				describeAvailableClassesResponse_dBInstanceClasses.Add(dBInstanceClass);
			}
			describeAvailableClassesResponse.DBInstanceClasses = describeAvailableClassesResponse_dBInstanceClasses;
        
			return describeAvailableClassesResponse;
        }
    }
}

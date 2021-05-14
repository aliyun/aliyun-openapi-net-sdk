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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeRdsSuperAccountInstancesResponseUnmarshaller
    {
        public static DescribeRdsSuperAccountInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRdsSuperAccountInstancesResponse describeRdsSuperAccountInstancesResponse = new DescribeRdsSuperAccountInstancesResponse();

			describeRdsSuperAccountInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeRdsSuperAccountInstancesResponse.RequestId = _ctx.StringValue("DescribeRdsSuperAccountInstances.RequestId");

			List<string> describeRdsSuperAccountInstancesResponse_dbInstances = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeRdsSuperAccountInstances.DbInstances.Length"); i++) {
				describeRdsSuperAccountInstancesResponse_dbInstances.Add(_ctx.StringValue("DescribeRdsSuperAccountInstances.DbInstances["+ i +"]"));
			}
			describeRdsSuperAccountInstancesResponse.DbInstances = describeRdsSuperAccountInstancesResponse_dbInstances;
        
			return describeRdsSuperAccountInstancesResponse;
        }
    }
}

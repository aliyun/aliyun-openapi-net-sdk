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
    public class DescribeClassDetailsResponseUnmarshaller
    {
        public static DescribeClassDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClassDetailsResponse describeClassDetailsResponse = new DescribeClassDetailsResponse();

			describeClassDetailsResponse.HttpResponse = _ctx.HttpResponse;
			describeClassDetailsResponse.RequestId = _ctx.StringValue("DescribeClassDetails.RequestId");
			describeClassDetailsResponse.ClassCode = _ctx.StringValue("DescribeClassDetails.ClassCode");
			describeClassDetailsResponse.MaxIOMBPS = _ctx.StringValue("DescribeClassDetails.MaxIOMBPS");
			describeClassDetailsResponse.MaxConnections = _ctx.StringValue("DescribeClassDetails.MaxConnections");
			describeClassDetailsResponse.ClassGroup = _ctx.StringValue("DescribeClassDetails.ClassGroup");
			describeClassDetailsResponse.Cpu = _ctx.StringValue("DescribeClassDetails.Cpu");
			describeClassDetailsResponse.InstructionSetArch = _ctx.StringValue("DescribeClassDetails.InstructionSetArch");
			describeClassDetailsResponse.MemoryClass = _ctx.StringValue("DescribeClassDetails.MemoryClass");
			describeClassDetailsResponse.MaxIOPS = _ctx.StringValue("DescribeClassDetails.MaxIOPS");
			describeClassDetailsResponse.ReferencePrice = _ctx.StringValue("DescribeClassDetails.ReferencePrice");
			describeClassDetailsResponse.Category = _ctx.StringValue("DescribeClassDetails.Category");
			describeClassDetailsResponse.DBInstanceStorageType = _ctx.StringValue("DescribeClassDetails.DBInstanceStorageType");
        
			return describeClassDetailsResponse;
        }
    }
}

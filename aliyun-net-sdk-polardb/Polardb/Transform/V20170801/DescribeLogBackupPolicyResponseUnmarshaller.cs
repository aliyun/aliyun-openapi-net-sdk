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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeLogBackupPolicyResponseUnmarshaller
    {
        public static DescribeLogBackupPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLogBackupPolicyResponse describeLogBackupPolicyResponse = new DescribeLogBackupPolicyResponse();

			describeLogBackupPolicyResponse.HttpResponse = _ctx.HttpResponse;
			describeLogBackupPolicyResponse.RequestId = _ctx.StringValue("DescribeLogBackupPolicy.RequestId");
			describeLogBackupPolicyResponse.EnableBackupLog = _ctx.IntegerValue("DescribeLogBackupPolicy.EnableBackupLog");
			describeLogBackupPolicyResponse.LogBackupRetentionPeriod = _ctx.IntegerValue("DescribeLogBackupPolicy.LogBackupRetentionPeriod");
        
			return describeLogBackupPolicyResponse;
        }
    }
}

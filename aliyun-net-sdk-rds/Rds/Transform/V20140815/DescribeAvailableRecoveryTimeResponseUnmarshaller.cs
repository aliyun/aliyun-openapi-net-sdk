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
    public class DescribeAvailableRecoveryTimeResponseUnmarshaller
    {
        public static DescribeAvailableRecoveryTimeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableRecoveryTimeResponse describeAvailableRecoveryTimeResponse = new DescribeAvailableRecoveryTimeResponse();

			describeAvailableRecoveryTimeResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableRecoveryTimeResponse.RequestId = _ctx.StringValue("DescribeAvailableRecoveryTime.RequestId");
			describeAvailableRecoveryTimeResponse.RecoveryBeginTime = _ctx.StringValue("DescribeAvailableRecoveryTime.RecoveryBeginTime");
			describeAvailableRecoveryTimeResponse.RecoveryEndTime = _ctx.StringValue("DescribeAvailableRecoveryTime.RecoveryEndTime");
			describeAvailableRecoveryTimeResponse.DBInstanceId = _ctx.StringValue("DescribeAvailableRecoveryTime.DBInstanceId");
			describeAvailableRecoveryTimeResponse.RegionId = _ctx.StringValue("DescribeAvailableRecoveryTime.RegionId");
			describeAvailableRecoveryTimeResponse.CrossBackupId = _ctx.IntegerValue("DescribeAvailableRecoveryTime.CrossBackupId");
        
			return describeAvailableRecoveryTimeResponse;
        }
    }
}

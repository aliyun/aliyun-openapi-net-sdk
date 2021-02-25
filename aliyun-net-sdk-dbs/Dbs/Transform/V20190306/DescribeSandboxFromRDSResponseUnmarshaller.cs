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
using Aliyun.Acs.Dbs.Model.V20190306;

namespace Aliyun.Acs.Dbs.Transform.V20190306
{
    public class DescribeSandboxFromRDSResponseUnmarshaller
    {
        public static DescribeSandboxFromRDSResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSandboxFromRDSResponse describeSandboxFromRDSResponse = new DescribeSandboxFromRDSResponse();

			describeSandboxFromRDSResponse.HttpResponse = _ctx.HttpResponse;
			describeSandboxFromRDSResponse.Success = _ctx.BooleanValue("DescribeSandboxFromRDS.Success");
			describeSandboxFromRDSResponse.ErrCode = _ctx.StringValue("DescribeSandboxFromRDS.ErrCode");
			describeSandboxFromRDSResponse.ErrMessage = _ctx.StringValue("DescribeSandboxFromRDS.ErrMessage");
			describeSandboxFromRDSResponse.HttpStatusCode = _ctx.IntegerValue("DescribeSandboxFromRDS.HttpStatusCode");
			describeSandboxFromRDSResponse.RequestId = _ctx.StringValue("DescribeSandboxFromRDS.RequestId");
			describeSandboxFromRDSResponse.SourceId = _ctx.StringValue("DescribeSandboxFromRDS.SourceId");
			describeSandboxFromRDSResponse.BackupPlanName = _ctx.StringValue("DescribeSandboxFromRDS.BackupPlanName");
			describeSandboxFromRDSResponse.BackupLog = _ctx.StringValue("DescribeSandboxFromRDS.BackupLog");
			describeSandboxFromRDSResponse.DbsInstanceId = _ctx.StringValue("DescribeSandboxFromRDS.DbsInstanceId");
			describeSandboxFromRDSResponse.SupportSandbox = _ctx.BooleanValue("DescribeSandboxFromRDS.SupportSandbox");
			describeSandboxFromRDSResponse.SandboxInstanceCount = _ctx.IntegerValue("DescribeSandboxFromRDS.SandboxInstanceCount");
			describeSandboxFromRDSResponse.SandboxRecoverStartTime = _ctx.LongValue("DescribeSandboxFromRDS.SandboxRecoverStartTime");
			describeSandboxFromRDSResponse.SandboxRecoverEndTime = _ctx.LongValue("DescribeSandboxFromRDS.SandboxRecoverEndTime");
			describeSandboxFromRDSResponse.EnabledSandbox = _ctx.BooleanValue("DescribeSandboxFromRDS.EnabledSandbox");
        
			return describeSandboxFromRDSResponse;
        }
    }
}

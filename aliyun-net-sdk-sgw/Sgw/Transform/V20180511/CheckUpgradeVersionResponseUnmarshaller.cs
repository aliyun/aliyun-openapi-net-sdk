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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class CheckUpgradeVersionResponseUnmarshaller
    {
        public static CheckUpgradeVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckUpgradeVersionResponse checkUpgradeVersionResponse = new CheckUpgradeVersionResponse();

			checkUpgradeVersionResponse.HttpResponse = _ctx.HttpResponse;
			checkUpgradeVersionResponse.RequestId = _ctx.StringValue("CheckUpgradeVersion.RequestId");
			checkUpgradeVersionResponse.Success = _ctx.BooleanValue("CheckUpgradeVersion.Success");
			checkUpgradeVersionResponse.Code = _ctx.StringValue("CheckUpgradeVersion.Code");
			checkUpgradeVersionResponse.Message = _ctx.StringValue("CheckUpgradeVersion.Message");
			checkUpgradeVersionResponse.Option = _ctx.StringValue("CheckUpgradeVersion.Option");
			checkUpgradeVersionResponse.LatestVersion = _ctx.StringValue("CheckUpgradeVersion.LatestVersion");

			List<CheckUpgradeVersionResponse.CheckUpgradeVersion_Patch> checkUpgradeVersionResponse_patches = new List<CheckUpgradeVersionResponse.CheckUpgradeVersion_Patch>();
			for (int i = 0; i < _ctx.Length("CheckUpgradeVersion.Patches.Length"); i++) {
				CheckUpgradeVersionResponse.CheckUpgradeVersion_Patch patch = new CheckUpgradeVersionResponse.CheckUpgradeVersion_Patch();
				patch.Name = _ctx.StringValue("CheckUpgradeVersion.Patches["+ i +"].Name");
				patch.MD5 = _ctx.StringValue("CheckUpgradeVersion.Patches["+ i +"].MD5");
				patch.Url = _ctx.StringValue("CheckUpgradeVersion.Patches["+ i +"].Url");
				patch.InternalUrl = _ctx.StringValue("CheckUpgradeVersion.Patches["+ i +"].InternalUrl");

				checkUpgradeVersionResponse_patches.Add(patch);
			}
			checkUpgradeVersionResponse.Patches = checkUpgradeVersionResponse_patches;
        
			return checkUpgradeVersionResponse;
        }
    }
}

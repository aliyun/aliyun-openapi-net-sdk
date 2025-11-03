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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class VerifyPlaybookResponseUnmarshaller
    {
        public static VerifyPlaybookResponse Unmarshall(UnmarshallerContext _ctx)
        {
			VerifyPlaybookResponse verifyPlaybookResponse = new VerifyPlaybookResponse();

			verifyPlaybookResponse.HttpResponse = _ctx.HttpResponse;
			verifyPlaybookResponse.RequestId = _ctx.StringValue("VerifyPlaybook.RequestId");

			List<VerifyPlaybookResponse.VerifyPlaybook_CheckTaskInfosItem> verifyPlaybookResponse_checkTaskInfos = new List<VerifyPlaybookResponse.VerifyPlaybook_CheckTaskInfosItem>();
			for (int i = 0; i < _ctx.Length("VerifyPlaybook.CheckTaskInfos.Length"); i++) {
				VerifyPlaybookResponse.VerifyPlaybook_CheckTaskInfosItem checkTaskInfosItem = new VerifyPlaybookResponse.VerifyPlaybook_CheckTaskInfosItem();
				checkTaskInfosItem.RiskLevel = _ctx.StringValue("VerifyPlaybook.CheckTaskInfos["+ i +"].RiskLevel");
				checkTaskInfosItem.NodeName = _ctx.StringValue("VerifyPlaybook.CheckTaskInfos["+ i +"].NodeName");
				checkTaskInfosItem.Detail = _ctx.StringValue("VerifyPlaybook.CheckTaskInfos["+ i +"].Detail");

				verifyPlaybookResponse_checkTaskInfos.Add(checkTaskInfosItem);
			}
			verifyPlaybookResponse.CheckTaskInfos = verifyPlaybookResponse_checkTaskInfos;

			List<VerifyPlaybookResponse.VerifyPlaybook_PrerequisitesItem> verifyPlaybookResponse_prerequisites = new List<VerifyPlaybookResponse.VerifyPlaybook_PrerequisitesItem>();
			for (int i = 0; i < _ctx.Length("VerifyPlaybook.Prerequisites.Length"); i++) {
				VerifyPlaybookResponse.VerifyPlaybook_PrerequisitesItem prerequisitesItem = new VerifyPlaybookResponse.VerifyPlaybook_PrerequisitesItem();
				prerequisitesItem.PrerequisiteType = _ctx.StringValue("VerifyPlaybook.Prerequisites["+ i +"].PrerequisiteType");
				prerequisitesItem.PrerequisiteValue = _ctx.StringValue("VerifyPlaybook.Prerequisites["+ i +"].PrerequisiteValue");

				verifyPlaybookResponse_prerequisites.Add(prerequisitesItem);
			}
			verifyPlaybookResponse.Prerequisites = verifyPlaybookResponse_prerequisites;
        
			return verifyPlaybookResponse;
        }
    }
}

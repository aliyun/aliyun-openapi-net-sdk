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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class PreviewGtmRecoveryPlanResponseUnmarshaller
    {
        public static PreviewGtmRecoveryPlanResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PreviewGtmRecoveryPlanResponse previewGtmRecoveryPlanResponse = new PreviewGtmRecoveryPlanResponse();

			previewGtmRecoveryPlanResponse.HttpResponse = _ctx.HttpResponse;
			previewGtmRecoveryPlanResponse.RequestId = _ctx.StringValue("PreviewGtmRecoveryPlan.RequestId");
			previewGtmRecoveryPlanResponse.TotalItems = _ctx.IntegerValue("PreviewGtmRecoveryPlan.TotalItems");
			previewGtmRecoveryPlanResponse.TotalPages = _ctx.IntegerValue("PreviewGtmRecoveryPlan.TotalPages");
			previewGtmRecoveryPlanResponse.PageSize = _ctx.IntegerValue("PreviewGtmRecoveryPlan.PageSize");
			previewGtmRecoveryPlanResponse.PageNumber = _ctx.IntegerValue("PreviewGtmRecoveryPlan.PageNumber");

			List<PreviewGtmRecoveryPlanResponse.PreviewGtmRecoveryPlan_Preview> previewGtmRecoveryPlanResponse_previews = new List<PreviewGtmRecoveryPlanResponse.PreviewGtmRecoveryPlan_Preview>();
			for (int i = 0; i < _ctx.Length("PreviewGtmRecoveryPlan.Previews.Length"); i++) {
				PreviewGtmRecoveryPlanResponse.PreviewGtmRecoveryPlan_Preview preview = new PreviewGtmRecoveryPlanResponse.PreviewGtmRecoveryPlan_Preview();
				preview.InstanceId = _ctx.StringValue("PreviewGtmRecoveryPlan.Previews["+ i +"].InstanceId");
				preview.Name = _ctx.StringValue("PreviewGtmRecoveryPlan.Previews["+ i +"].Name");
				preview.UserDomainName = _ctx.StringValue("PreviewGtmRecoveryPlan.Previews["+ i +"].UserDomainName");

				List<PreviewGtmRecoveryPlanResponse.PreviewGtmRecoveryPlan_Preview.PreviewGtmRecoveryPlan_SwitchInfo> preview_switchInfos = new List<PreviewGtmRecoveryPlanResponse.PreviewGtmRecoveryPlan_Preview.PreviewGtmRecoveryPlan_SwitchInfo>();
				for (int j = 0; j < _ctx.Length("PreviewGtmRecoveryPlan.Previews["+ i +"].SwitchInfos.Length"); j++) {
					PreviewGtmRecoveryPlanResponse.PreviewGtmRecoveryPlan_Preview.PreviewGtmRecoveryPlan_SwitchInfo switchInfo = new PreviewGtmRecoveryPlanResponse.PreviewGtmRecoveryPlan_Preview.PreviewGtmRecoveryPlan_SwitchInfo();
					switchInfo.StrategyName = _ctx.StringValue("PreviewGtmRecoveryPlan.Previews["+ i +"].SwitchInfos["+ j +"].StrategyName");
					switchInfo.Content = _ctx.StringValue("PreviewGtmRecoveryPlan.Previews["+ i +"].SwitchInfos["+ j +"].Content");

					preview_switchInfos.Add(switchInfo);
				}
				preview.SwitchInfos = preview_switchInfos;

				previewGtmRecoveryPlanResponse_previews.Add(preview);
			}
			previewGtmRecoveryPlanResponse.Previews = previewGtmRecoveryPlanResponse_previews;
        
			return previewGtmRecoveryPlanResponse;
        }
    }
}

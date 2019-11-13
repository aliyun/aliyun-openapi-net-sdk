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
        public static PreviewGtmRecoveryPlanResponse Unmarshall(UnmarshallerContext context)
        {
			PreviewGtmRecoveryPlanResponse previewGtmRecoveryPlanResponse = new PreviewGtmRecoveryPlanResponse();

			previewGtmRecoveryPlanResponse.HttpResponse = context.HttpResponse;
			previewGtmRecoveryPlanResponse.RequestId = context.StringValue("PreviewGtmRecoveryPlan.RequestId");
			previewGtmRecoveryPlanResponse.TotalItems = context.IntegerValue("PreviewGtmRecoveryPlan.TotalItems");
			previewGtmRecoveryPlanResponse.TotalPages = context.IntegerValue("PreviewGtmRecoveryPlan.TotalPages");
			previewGtmRecoveryPlanResponse.PageSize = context.IntegerValue("PreviewGtmRecoveryPlan.PageSize");
			previewGtmRecoveryPlanResponse.PageNumber = context.IntegerValue("PreviewGtmRecoveryPlan.PageNumber");

			List<PreviewGtmRecoveryPlanResponse.PreviewGtmRecoveryPlan_Preview> previewGtmRecoveryPlanResponse_previews = new List<PreviewGtmRecoveryPlanResponse.PreviewGtmRecoveryPlan_Preview>();
			for (int i = 0; i < context.Length("PreviewGtmRecoveryPlan.Previews.Length"); i++) {
				PreviewGtmRecoveryPlanResponse.PreviewGtmRecoveryPlan_Preview preview = new PreviewGtmRecoveryPlanResponse.PreviewGtmRecoveryPlan_Preview();
				preview.InstanceId = context.StringValue("PreviewGtmRecoveryPlan.Previews["+ i +"].InstanceId");
				preview.Name = context.StringValue("PreviewGtmRecoveryPlan.Previews["+ i +"].Name");
				preview.UserDomainName = context.StringValue("PreviewGtmRecoveryPlan.Previews["+ i +"].UserDomainName");

				List<PreviewGtmRecoveryPlanResponse.PreviewGtmRecoveryPlan_Preview.PreviewGtmRecoveryPlan_SwitchInfo> preview_switchInfos = new List<PreviewGtmRecoveryPlanResponse.PreviewGtmRecoveryPlan_Preview.PreviewGtmRecoveryPlan_SwitchInfo>();
				for (int j = 0; j < context.Length("PreviewGtmRecoveryPlan.Previews["+ i +"].SwitchInfos.Length"); j++) {
					PreviewGtmRecoveryPlanResponse.PreviewGtmRecoveryPlan_Preview.PreviewGtmRecoveryPlan_SwitchInfo switchInfo = new PreviewGtmRecoveryPlanResponse.PreviewGtmRecoveryPlan_Preview.PreviewGtmRecoveryPlan_SwitchInfo();
					switchInfo.StrategyName = context.StringValue("PreviewGtmRecoveryPlan.Previews["+ i +"].SwitchInfos["+ j +"].StrategyName");
					switchInfo.Content = context.StringValue("PreviewGtmRecoveryPlan.Previews["+ i +"].SwitchInfos["+ j +"].Content");

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

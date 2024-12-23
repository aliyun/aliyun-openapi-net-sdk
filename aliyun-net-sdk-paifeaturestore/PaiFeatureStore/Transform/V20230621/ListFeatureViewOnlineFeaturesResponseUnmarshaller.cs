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
using Aliyun.Acs.PaiFeatureStore.Model.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Transform.V20230621
{
    public class ListFeatureViewOnlineFeaturesResponseUnmarshaller
    {
        public static ListFeatureViewOnlineFeaturesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFeatureViewOnlineFeaturesResponse listFeatureViewOnlineFeaturesResponse = new ListFeatureViewOnlineFeaturesResponse();

			listFeatureViewOnlineFeaturesResponse.HttpResponse = _ctx.HttpResponse;
			listFeatureViewOnlineFeaturesResponse.RequestId = _ctx.StringValue("ListFeatureViewOnlineFeatures.RequestId");

			List<string> listFeatureViewOnlineFeaturesResponse_onlineFeatures = new List<string>();
			for (int i = 0; i < _ctx.Length("ListFeatureViewOnlineFeatures.OnlineFeatures.Length"); i++) {
				listFeatureViewOnlineFeaturesResponse_onlineFeatures.Add(_ctx.StringValue("ListFeatureViewOnlineFeatures.OnlineFeatures["+ i +"]"));
			}
			listFeatureViewOnlineFeaturesResponse.OnlineFeatures = listFeatureViewOnlineFeaturesResponse_onlineFeatures;
        
			return listFeatureViewOnlineFeaturesResponse;
        }
    }
}

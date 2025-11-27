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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.PaiFeatureStore;
using Aliyun.Acs.PaiFeatureStore.Transform;
using Aliyun.Acs.PaiFeatureStore.Transform.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Model.V20230621
{
    public class ListFeatureViewOnlineFeaturesRequest : RoaAcsRequest<ListFeatureViewOnlineFeaturesResponse>
    {
        public ListFeatureViewOnlineFeaturesRequest()
            : base("PaiFeatureStore", "2023-06-21", "ListFeatureViewOnlineFeatures")
        {
			UriPattern = "/api/v1/instances/[InstanceId]/featureviews/[FeatureViewId]/onlinefeatures";
			Method = MethodType.GET;
        }

		private string instanceId;

		private string joinIds;

		private string featureViewId;

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(PathParameters, "InstanceId", value);
			}
		}

		public string JoinIds
		{
			get
			{
				return joinIds;
			}
			set	
			{
				joinIds = value;
				DictionaryUtil.Add(QueryParameters, "JoinIds", value);
			}
		}

		public string FeatureViewId
		{
			get
			{
				return featureViewId;
			}
			set	
			{
				featureViewId = value;
				DictionaryUtil.Add(PathParameters, "FeatureViewId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListFeatureViewOnlineFeaturesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListFeatureViewOnlineFeaturesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

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
    public class ListFeatureViewFieldRelationshipsRequest : RoaAcsRequest<ListFeatureViewFieldRelationshipsResponse>
    {
        public ListFeatureViewFieldRelationshipsRequest()
            : base("PaiFeatureStore", "2023-06-21", "ListFeatureViewFieldRelationships")
        {
			UriPattern = "/api/v1/instances/[InstanceId]/featureviews/[FeatureViewId]/fields/[FieldName]/relationships";
			Method = MethodType.GET;
        }

		private string fieldName;

		private string instanceId;

		private string featureViewId;

		public string FieldName
		{
			get
			{
				return fieldName;
			}
			set	
			{
				fieldName = value;
				DictionaryUtil.Add(PathParameters, "FieldName", value);
			}
		}

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

        public override ListFeatureViewFieldRelationshipsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListFeatureViewFieldRelationshipsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

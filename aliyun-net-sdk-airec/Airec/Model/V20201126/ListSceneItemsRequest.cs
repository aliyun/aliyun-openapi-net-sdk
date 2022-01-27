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
using Aliyun.Acs.Airec.Transform;
using Aliyun.Acs.Airec.Transform.V20201126;

namespace Aliyun.Acs.Airec.Model.V20201126
{
    public class ListSceneItemsRequest : RoaAcsRequest<ListSceneItemsResponse>
    {
        public ListSceneItemsRequest()
            : base("Airec", "2020-11-26", "ListSceneItems", "airec", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Airec.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Airec.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/v2/openapi/instances/[instanceId]/scenes/[sceneId]/items";
			Method = MethodType.GET;
        }

		private string selectionRuleId;

		private string instanceId;

		private int? size;

		private int? queryCount;

		private string sceneId;

		private string operationRuleId;

		private string previewType;

		private int? page;

		public string SelectionRuleId
		{
			get
			{
				return selectionRuleId;
			}
			set	
			{
				selectionRuleId = value;
				DictionaryUtil.Add(QueryParameters, "selectionRuleId", value);
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
				DictionaryUtil.Add(PathParameters, "instanceId", value);
			}
		}

		public int? Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(QueryParameters, "size", value.ToString());
			}
		}

		public int? QueryCount
		{
			get
			{
				return queryCount;
			}
			set	
			{
				queryCount = value;
				DictionaryUtil.Add(QueryParameters, "queryCount", value.ToString());
			}
		}

		public string SceneId
		{
			get
			{
				return sceneId;
			}
			set	
			{
				sceneId = value;
				DictionaryUtil.Add(PathParameters, "sceneId", value);
			}
		}

		public string OperationRuleId
		{
			get
			{
				return operationRuleId;
			}
			set	
			{
				operationRuleId = value;
				DictionaryUtil.Add(QueryParameters, "operationRuleId", value);
			}
		}

		public string PreviewType
		{
			get
			{
				return previewType;
			}
			set	
			{
				previewType = value;
				DictionaryUtil.Add(QueryParameters, "previewType", value);
			}
		}

		public int? Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
				DictionaryUtil.Add(QueryParameters, "page", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListSceneItemsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListSceneItemsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

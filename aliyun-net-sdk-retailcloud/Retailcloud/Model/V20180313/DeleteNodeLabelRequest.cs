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
using Aliyun.Acs.retailcloud.Transform;
using Aliyun.Acs.retailcloud.Transform.V20180313;

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
    public class DeleteNodeLabelRequest : RpcAcsRequest<DeleteNodeLabelResponse>
    {
        public DeleteNodeLabelRequest()
            : base("retailcloud", "2018-03-13", "DeleteNodeLabel", "retailcloud", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string labelKey;

		private string labelValue;

		private bool? force;

		private string clusterId;

		public string LabelKey
		{
			get
			{
				return labelKey;
			}
			set	
			{
				labelKey = value;
				DictionaryUtil.Add(QueryParameters, "LabelKey", value);
			}
		}

		public string LabelValue
		{
			get
			{
				return labelValue;
			}
			set	
			{
				labelValue = value;
				DictionaryUtil.Add(QueryParameters, "LabelValue", value);
			}
		}

		public bool? Force
		{
			get
			{
				return force;
			}
			set	
			{
				force = value;
				DictionaryUtil.Add(QueryParameters, "Force", value.ToString());
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteNodeLabelResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteNodeLabelResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

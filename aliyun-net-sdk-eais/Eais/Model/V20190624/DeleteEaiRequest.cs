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
using Aliyun.Acs.eais.Transform;
using Aliyun.Acs.eais.Transform.V20190624;

namespace Aliyun.Acs.eais.Model.V20190624
{
    public class DeleteEaiRequest : RpcAcsRequest<DeleteEaiResponse>
    {
        public DeleteEaiRequest()
            : base("eais", "2019-06-24", "DeleteEai", "eais", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.eais.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.eais.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string elasticAcceleratedInstanceId;

		private bool? force;

		public string ElasticAcceleratedInstanceId
		{
			get
			{
				return elasticAcceleratedInstanceId;
			}
			set	
			{
				elasticAcceleratedInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "ElasticAcceleratedInstanceId", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteEaiResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteEaiResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

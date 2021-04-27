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
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class DescribeGraph4InvestigationOnlineRequest : RpcAcsRequest<DescribeGraph4InvestigationOnlineResponse>
    {
        public DescribeGraph4InvestigationOnlineRequest()
            : base("Sas", "2018-12-03", "DescribeGraph4InvestigationOnline", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string vertexId;

		private string anomalyId;

		private string anomalyUuid;

		private string lang;

		private string direction;

		private int? pathLength;

		private string _namespace;

		public string VertexId
		{
			get
			{
				return vertexId;
			}
			set	
			{
				vertexId = value;
				DictionaryUtil.Add(QueryParameters, "VertexId", value);
			}
		}

		public string AnomalyId
		{
			get
			{
				return anomalyId;
			}
			set	
			{
				anomalyId = value;
				DictionaryUtil.Add(QueryParameters, "AnomalyId", value);
			}
		}

		public string AnomalyUuid
		{
			get
			{
				return anomalyUuid;
			}
			set	
			{
				anomalyUuid = value;
				DictionaryUtil.Add(QueryParameters, "AnomalyUuid", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string Direction
		{
			get
			{
				return direction;
			}
			set	
			{
				direction = value;
				DictionaryUtil.Add(QueryParameters, "Direction", value);
			}
		}

		public int? PathLength
		{
			get
			{
				return pathLength;
			}
			set	
			{
				pathLength = value;
				DictionaryUtil.Add(QueryParameters, "PathLength", value.ToString());
			}
		}

		public string _Namespace
		{
			get
			{
				return _namespace;
			}
			set	
			{
				_namespace = value;
				DictionaryUtil.Add(QueryParameters, "Namespace", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeGraph4InvestigationOnlineResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeGraph4InvestigationOnlineResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

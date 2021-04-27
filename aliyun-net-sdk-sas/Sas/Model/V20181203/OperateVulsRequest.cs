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
    public class OperateVulsRequest : RpcAcsRequest<OperateVulsResponse>
    {
        public OperateVulsRequest()
            : base("Sas", "2018-12-03", "OperateVuls", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string reason;

		private string type;

		private List<string> vulNamess = new List<string>(){ };

		private int? precondition;

		private string operateType;

		private List<string> uuidss = new List<string>(){ };

		public string Reason
		{
			get
			{
				return reason;
			}
			set	
			{
				reason = value;
				DictionaryUtil.Add(QueryParameters, "Reason", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public List<string> VulNamess
		{
			get
			{
				return vulNamess;
			}

			set
			{
				vulNamess = value;
				for (int i = 0; i < vulNamess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"VulNames." + (i + 1) , vulNamess[i]);
				}
			}
		}

		public int? Precondition
		{
			get
			{
				return precondition;
			}
			set	
			{
				precondition = value;
				DictionaryUtil.Add(QueryParameters, "Precondition", value.ToString());
			}
		}

		public string OperateType
		{
			get
			{
				return operateType;
			}
			set	
			{
				operateType = value;
				DictionaryUtil.Add(QueryParameters, "OperateType", value);
			}
		}

		public List<string> Uuidss
		{
			get
			{
				return uuidss;
			}

			set
			{
				uuidss = value;
				for (int i = 0; i < uuidss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Uuids." + (i + 1) , uuidss[i]);
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override OperateVulsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return OperateVulsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

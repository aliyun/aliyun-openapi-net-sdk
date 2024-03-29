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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.DBFS.Transform;
using Aliyun.Acs.DBFS.Transform.V20200418;

namespace Aliyun.Acs.DBFS.Model.V20200418
{
    public class AttachDbfsRequest : RpcAcsRequest<AttachDbfsResponse>
    {
        public AttachDbfsRequest()
            : base("DBFS", "2020-04-18", "AttachDbfs", "dbfs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.DBFS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.DBFS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string eCSInstanceId;

		private string attachPoint;

		private string serverUrl;

		private string fsId;

		private string attachMode;

		[JsonProperty(PropertyName = "ECSInstanceId")]
		public string ECSInstanceId
		{
			get
			{
				return eCSInstanceId;
			}
			set	
			{
				eCSInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "ECSInstanceId", value);
			}
		}

		[JsonProperty(PropertyName = "AttachPoint")]
		public string AttachPoint
		{
			get
			{
				return attachPoint;
			}
			set	
			{
				attachPoint = value;
				DictionaryUtil.Add(QueryParameters, "AttachPoint", value);
			}
		}

		[JsonProperty(PropertyName = "ServerUrl")]
		public string ServerUrl
		{
			get
			{
				return serverUrl;
			}
			set	
			{
				serverUrl = value;
				DictionaryUtil.Add(QueryParameters, "ServerUrl", value);
			}
		}

		[JsonProperty(PropertyName = "FsId")]
		public string FsId
		{
			get
			{
				return fsId;
			}
			set	
			{
				fsId = value;
				DictionaryUtil.Add(QueryParameters, "FsId", value);
			}
		}

		[JsonProperty(PropertyName = "AttachMode")]
		public string AttachMode
		{
			get
			{
				return attachMode;
			}
			set	
			{
				attachMode = value;
				DictionaryUtil.Add(QueryParameters, "AttachMode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AttachDbfsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AttachDbfsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

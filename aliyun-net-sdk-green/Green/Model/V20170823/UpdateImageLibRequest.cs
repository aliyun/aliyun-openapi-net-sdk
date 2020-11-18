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
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20170823;

namespace Aliyun.Acs.Green.Model.V20170823
{
    public class UpdateImageLibRequest : RpcAcsRequest<UpdateImageLibResponse>
    {
        public UpdateImageLibRequest()
            : base("Green", "2017-08-23", "UpdateImageLib", "green", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string scene;

		private string sourceIp;

		private bool? enable;

		private int? id;

		private string bizTypes;

		private string name;

		private string category;

		public string Scene
		{
			get
			{
				return scene;
			}
			set	
			{
				scene = value;
				DictionaryUtil.Add(QueryParameters, "Scene", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public bool? Enable
		{
			get
			{
				return enable;
			}
			set	
			{
				enable = value;
				DictionaryUtil.Add(QueryParameters, "Enable", value.ToString());
			}
		}

		public int? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
			}
		}

		public string BizTypes
		{
			get
			{
				return bizTypes;
			}
			set	
			{
				bizTypes = value;
				DictionaryUtil.Add(QueryParameters, "BizTypes", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string Category
		{
			get
			{
				return category;
			}
			set	
			{
				category = value;
				DictionaryUtil.Add(QueryParameters, "Category", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateImageLibResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateImageLibResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

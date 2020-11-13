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
using Aliyun.Acs.facebody.Transform;
using Aliyun.Acs.facebody.Transform.V20191230;

namespace Aliyun.Acs.facebody.Model.V20191230
{
    public class CompareFaceRequest : RpcAcsRequest<CompareFaceResponse>
    {
        public CompareFaceRequest()
            : base("facebody", "2019-12-30", "CompareFace", "facebody", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.facebody.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.facebody.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string imageURLB;

		private string imageURLA;

		public string ImageURLB
		{
			get
			{
				return imageURLB;
			}
			set	
			{
				imageURLB = value;
				DictionaryUtil.Add(BodyParameters, "ImageURLB", value);
			}
		}

		public string ImageURLA
		{
			get
			{
				return imageURLA;
			}
			set	
			{
				imageURLA = value;
				DictionaryUtil.Add(BodyParameters, "ImageURLA", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CompareFaceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CompareFaceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

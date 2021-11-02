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
using Aliyun.Acs.vod;
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class UpdateWatermarkRequest : RpcAcsRequest<UpdateWatermarkResponse>
    {
        public UpdateWatermarkRequest()
            : base("vod", "2017-03-21", "UpdateWatermark")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string watermarkConfig;

		private string watermarkId;

		private string name;

		public string WatermarkConfig
		{
			get
			{
				return watermarkConfig;
			}
			set	
			{
				watermarkConfig = value;
				DictionaryUtil.Add(QueryParameters, "WatermarkConfig", value);
			}
		}

		public string WatermarkId
		{
			get
			{
				return watermarkId;
			}
			set	
			{
				watermarkId = value;
				DictionaryUtil.Add(QueryParameters, "WatermarkId", value);
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

        public override UpdateWatermarkResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateWatermarkResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

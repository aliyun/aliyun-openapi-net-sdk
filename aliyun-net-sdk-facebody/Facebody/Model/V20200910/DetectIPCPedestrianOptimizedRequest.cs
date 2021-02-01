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
using Aliyun.Acs.facebody.Transform.V20200910;

namespace Aliyun.Acs.facebody.Model.V20200910
{
    public class DetectIPCPedestrianOptimizedRequest : RoaAcsRequest<DetectIPCPedestrianOptimizedResponse>
    {
        public DetectIPCPedestrianOptimizedRequest()
            : base("facebody", "2020-09-10", "DetectIPCPedestrianOptimized", "facebody", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.facebody.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.facebody.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/viapi/k8s/facebody/detect-ipc-pedestrian-optimized";
			Method = MethodType.POST;
        }

		private string imageData;

		private long? width;

		private long? height;

		public string ImageData
		{
			get
			{
				return imageData;
			}
			set	
			{
				imageData = value;
				DictionaryUtil.Add(BodyParameters, "imageData", value);
			}
		}

		public long? Width
		{
			get
			{
				return width;
			}
			set	
			{
				width = value;
				DictionaryUtil.Add(BodyParameters, "width", value.ToString());
			}
		}

		public long? Height
		{
			get
			{
				return height;
			}
			set	
			{
				height = value;
				DictionaryUtil.Add(BodyParameters, "height", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DetectIPCPedestrianOptimizedResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DetectIPCPedestrianOptimizedResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

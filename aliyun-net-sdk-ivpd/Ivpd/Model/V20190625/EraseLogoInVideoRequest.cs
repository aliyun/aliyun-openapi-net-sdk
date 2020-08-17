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
using Aliyun.Acs.ivpd.Transform;
using Aliyun.Acs.ivpd.Transform.V20190625;

namespace Aliyun.Acs.ivpd.Model.V20190625
{
    public class EraseLogoInVideoRequest : RpcAcsRequest<EraseLogoInVideoResponse>
    {
        public EraseLogoInVideoRequest()
            : base("ivpd", "2019-06-25", "EraseLogoInVideo", "ivpd", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<Boxes> boxess = new List<Boxes>(){ };

		private string jobId;

		private string videoUrl;

		public List<Boxes> Boxess
		{
			get
			{
				return boxess;
			}

			set
			{
				boxess = value;
				for (int i = 0; i < boxess.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Boxes." + (i + 1) + ".W", boxess[i].W);
					DictionaryUtil.Add(BodyParameters,"Boxes." + (i + 1) + ".H", boxess[i].H);
					DictionaryUtil.Add(BodyParameters,"Boxes." + (i + 1) + ".X", boxess[i].X);
					DictionaryUtil.Add(BodyParameters,"Boxes." + (i + 1) + ".Y", boxess[i].Y);
				}
			}
		}

		public string JobId
		{
			get
			{
				return jobId;
			}
			set	
			{
				jobId = value;
				DictionaryUtil.Add(BodyParameters, "JobId", value);
			}
		}

		public string VideoUrl
		{
			get
			{
				return videoUrl;
			}
			set	
			{
				videoUrl = value;
				DictionaryUtil.Add(BodyParameters, "VideoUrl", value);
			}
		}

		public class Boxes
		{

			private float? w;

			private float? h;

			private float? x;

			private float? y;

			public float? W
			{
				get
				{
					return w;
				}
				set	
				{
					w = value;
				}
			}

			public float? H
			{
				get
				{
					return h;
				}
				set	
				{
					h = value;
				}
			}

			public float? X
			{
				get
				{
					return x;
				}
				set	
				{
					x = value;
				}
			}

			public float? Y
			{
				get
				{
					return y;
				}
				set	
				{
					y = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override EraseLogoInVideoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return EraseLogoInVideoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

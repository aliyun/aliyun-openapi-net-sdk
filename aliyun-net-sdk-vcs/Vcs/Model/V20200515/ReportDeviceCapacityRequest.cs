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
using Aliyun.Acs.Vcs;
using Aliyun.Acs.Vcs.Transform;
using Aliyun.Acs.Vcs.Transform.V20200515;

namespace Aliyun.Acs.Vcs.Model.V20200515
{
    public class ReportDeviceCapacityRequest : RpcAcsRequest<ReportDeviceCapacityResponse>
    {
        public ReportDeviceCapacityRequest()
            : base("Vcs", "2020-05-15", "ReportDeviceCapacity")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<StreamCapacities> streamCapacitiess = new List<StreamCapacities>(){ };

		private string latitude;

		private string presetNum;

		private string deviceTimeStamp;

		private string deviceSn;

		private string audioFormat;

		private string pTZCapacity;

		private string longitude;

		public List<StreamCapacities> StreamCapacitiess
		{
			get
			{
				return streamCapacitiess;
			}

			set
			{
				streamCapacitiess = value;
				for (int i = 0; i < streamCapacitiess.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"StreamCapacities." + (i + 1) + ".BitrateRange", streamCapacitiess[i].BitrateRange);
					DictionaryUtil.Add(BodyParameters,"StreamCapacities." + (i + 1) + ".MaxStream", streamCapacitiess[i].MaxStream);
					DictionaryUtil.Add(BodyParameters,"StreamCapacities." + (i + 1) + ".EncodeFormat", streamCapacitiess[i].EncodeFormat);
					DictionaryUtil.Add(BodyParameters,"StreamCapacities." + (i + 1) + ".MaxFrameRate", streamCapacitiess[i].MaxFrameRate);
					DictionaryUtil.Add(BodyParameters,"StreamCapacities." + (i + 1) + ".GovLengthRange", streamCapacitiess[i].GovLengthRange);
					DictionaryUtil.Add(BodyParameters,"StreamCapacities." + (i + 1) + ".Resolution", streamCapacitiess[i].Resolution);
				}
			}
		}

		public string Latitude
		{
			get
			{
				return latitude;
			}
			set	
			{
				latitude = value;
				DictionaryUtil.Add(BodyParameters, "Latitude", value);
			}
		}

		public string PresetNum
		{
			get
			{
				return presetNum;
			}
			set	
			{
				presetNum = value;
				DictionaryUtil.Add(BodyParameters, "PresetNum", value);
			}
		}

		public string DeviceTimeStamp
		{
			get
			{
				return deviceTimeStamp;
			}
			set	
			{
				deviceTimeStamp = value;
				DictionaryUtil.Add(BodyParameters, "DeviceTimeStamp", value);
			}
		}

		public string DeviceSn
		{
			get
			{
				return deviceSn;
			}
			set	
			{
				deviceSn = value;
				DictionaryUtil.Add(BodyParameters, "DeviceSn", value);
			}
		}

		public string AudioFormat
		{
			get
			{
				return audioFormat;
			}
			set	
			{
				audioFormat = value;
				DictionaryUtil.Add(BodyParameters, "AudioFormat", value);
			}
		}

		public string PTZCapacity
		{
			get
			{
				return pTZCapacity;
			}
			set	
			{
				pTZCapacity = value;
				DictionaryUtil.Add(BodyParameters, "PTZCapacity", value);
			}
		}

		public string Longitude
		{
			get
			{
				return longitude;
			}
			set	
			{
				longitude = value;
				DictionaryUtil.Add(BodyParameters, "Longitude", value);
			}
		}

		public class StreamCapacities
		{

			private string bitrateRange;

			private string maxStream;

			private string encodeFormat;

			private string maxFrameRate;

			private string govLengthRange;

			private string resolution;

			public string BitrateRange
			{
				get
				{
					return bitrateRange;
				}
				set	
				{
					bitrateRange = value;
				}
			}

			public string MaxStream
			{
				get
				{
					return maxStream;
				}
				set	
				{
					maxStream = value;
				}
			}

			public string EncodeFormat
			{
				get
				{
					return encodeFormat;
				}
				set	
				{
					encodeFormat = value;
				}
			}

			public string MaxFrameRate
			{
				get
				{
					return maxFrameRate;
				}
				set	
				{
					maxFrameRate = value;
				}
			}

			public string GovLengthRange
			{
				get
				{
					return govLengthRange;
				}
				set	
				{
					govLengthRange = value;
				}
			}

			public string Resolution
			{
				get
				{
					return resolution;
				}
				set	
				{
					resolution = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ReportDeviceCapacityResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ReportDeviceCapacityResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

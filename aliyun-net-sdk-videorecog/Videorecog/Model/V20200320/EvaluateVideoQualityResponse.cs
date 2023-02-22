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

namespace Aliyun.Acs.videorecog.Model.V20200320
{
	public class EvaluateVideoQualityResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private EvaluateVideoQuality_Data data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public EvaluateVideoQuality_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class EvaluateVideoQuality_Data
		{

			private string jsonUrl;

			private string pdfUrl;

			private EvaluateVideoQuality_VideoQualityInfo videoQualityInfo;

			public string JsonUrl
			{
				get
				{
					return jsonUrl;
				}
				set	
				{
					jsonUrl = value;
				}
			}

			public string PdfUrl
			{
				get
				{
					return pdfUrl;
				}
				set	
				{
					pdfUrl = value;
				}
			}

			public EvaluateVideoQuality_VideoQualityInfo VideoQualityInfo
			{
				get
				{
					return videoQualityInfo;
				}
				set	
				{
					videoQualityInfo = value;
				}
			}

			public class EvaluateVideoQuality_VideoQualityInfo
			{

				private float? compressiveStrength;

				private float? noiseIntensity;

				private float? blurriness;

				private float? colorContrast;

				private float? colorSaturation;

				private float? luminance;

				private float? colorfulness;

				private float? mosScore;

				public float? CompressiveStrength
				{
					get
					{
						return compressiveStrength;
					}
					set	
					{
						compressiveStrength = value;
					}
				}

				public float? NoiseIntensity
				{
					get
					{
						return noiseIntensity;
					}
					set	
					{
						noiseIntensity = value;
					}
				}

				public float? Blurriness
				{
					get
					{
						return blurriness;
					}
					set	
					{
						blurriness = value;
					}
				}

				public float? ColorContrast
				{
					get
					{
						return colorContrast;
					}
					set	
					{
						colorContrast = value;
					}
				}

				public float? ColorSaturation
				{
					get
					{
						return colorSaturation;
					}
					set	
					{
						colorSaturation = value;
					}
				}

				public float? Luminance
				{
					get
					{
						return luminance;
					}
					set	
					{
						luminance = value;
					}
				}

				public float? Colorfulness
				{
					get
					{
						return colorfulness;
					}
					set	
					{
						colorfulness = value;
					}
				}

				public float? MosScore
				{
					get
					{
						return mosScore;
					}
					set	
					{
						mosScore = value;
					}
				}
			}
		}
	}
}

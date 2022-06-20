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

namespace Aliyun.Acs.imageprocess.Model.V20200320
{
	public class CalcCACSResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private CalcCACS_Data data;

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

		public CalcCACS_Data Data
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

		public class CalcCACS_Data
		{

			private string resultUrl;

			private string score;

			private string volumeScore;

			private List<CalcCACS_DetectionsItem> detections;

			public string ResultUrl
			{
				get
				{
					return resultUrl;
				}
				set	
				{
					resultUrl = value;
				}
			}

			public string Score
			{
				get
				{
					return score;
				}
				set	
				{
					score = value;
				}
			}

			public string VolumeScore
			{
				get
				{
					return volumeScore;
				}
				set	
				{
					volumeScore = value;
				}
			}

			public List<CalcCACS_DetectionsItem> Detections
			{
				get
				{
					return detections;
				}
				set	
				{
					detections = value;
				}
			}

			public class CalcCACS_DetectionsItem
			{

				private long? calciumId;

				private float? calciumScore;

				private float? calciumVolume;

				private List<string> calciumCenter;

				public long? CalciumId
				{
					get
					{
						return calciumId;
					}
					set	
					{
						calciumId = value;
					}
				}

				public float? CalciumScore
				{
					get
					{
						return calciumScore;
					}
					set	
					{
						calciumScore = value;
					}
				}

				public float? CalciumVolume
				{
					get
					{
						return calciumVolume;
					}
					set	
					{
						calciumVolume = value;
					}
				}

				public List<string> CalciumCenter
				{
					get
					{
						return calciumCenter;
					}
					set	
					{
						calciumCenter = value;
					}
				}
			}
		}
	}
}

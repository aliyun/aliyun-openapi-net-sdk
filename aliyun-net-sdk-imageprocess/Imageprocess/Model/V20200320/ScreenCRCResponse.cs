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
	public class ScreenCRCResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private ScreenCRC_Data data;

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

		public ScreenCRC_Data Data
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

		public class ScreenCRC_Data
		{

			private ScreenCRC_Lesion lesion;

			public ScreenCRC_Lesion Lesion
			{
				get
				{
					return lesion;
				}
				set	
				{
					lesion = value;
				}
			}

			public class ScreenCRC_Lesion
			{

				private string probabilities;

				private string stage2Volume;

				private string colorectumVolume;

				private string cRCVolume;

				private string nonCRCVolumel;

				private string mask;

				public string Probabilities
				{
					get
					{
						return probabilities;
					}
					set	
					{
						probabilities = value;
					}
				}

				public string Stage2Volume
				{
					get
					{
						return stage2Volume;
					}
					set	
					{
						stage2Volume = value;
					}
				}

				public string ColorectumVolume
				{
					get
					{
						return colorectumVolume;
					}
					set	
					{
						colorectumVolume = value;
					}
				}

				public string CRCVolume
				{
					get
					{
						return cRCVolume;
					}
					set	
					{
						cRCVolume = value;
					}
				}

				public string NonCRCVolumel
				{
					get
					{
						return nonCRCVolumel;
					}
					set	
					{
						nonCRCVolumel = value;
					}
				}

				public string Mask
				{
					get
					{
						return mask;
					}
					set	
					{
						mask = value;
					}
				}
			}
		}
	}
}

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
	public class ScreenGCResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private ScreenGC_Data data;

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

		public ScreenGC_Data Data
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

		public class ScreenGC_Data
		{

			private ScreenGC_Lesion lesion;

			public ScreenGC_Lesion Lesion
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

			public class ScreenGC_Lesion
			{

				private string probabilities;

				private string stage2Volume;

				private string stomachVolume;

				private string gCVolume;

				private string nonGCVolume;

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

				public string StomachVolume
				{
					get
					{
						return stomachVolume;
					}
					set	
					{
						stomachVolume = value;
					}
				}

				public string GCVolume
				{
					get
					{
						return gCVolume;
					}
					set	
					{
						gCVolume = value;
					}
				}

				public string NonGCVolume
				{
					get
					{
						return nonGCVolume;
					}
					set	
					{
						nonGCVolume = value;
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

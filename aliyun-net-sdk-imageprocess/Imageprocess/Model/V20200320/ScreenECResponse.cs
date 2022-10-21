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
	public class ScreenECResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private ScreenEC_Data data;

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

		public ScreenEC_Data Data
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

		public class ScreenEC_Data
		{

			private ScreenEC_Lesion lesion;

			public ScreenEC_Lesion Lesion
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

			public class ScreenEC_Lesion
			{

				private string esoVolume;

				private string ecVolume;

				private string benignVolume;

				private string mask;

				private List<string> possibilities;

				public string EsoVolume
				{
					get
					{
						return esoVolume;
					}
					set	
					{
						esoVolume = value;
					}
				}

				public string EcVolume
				{
					get
					{
						return ecVolume;
					}
					set	
					{
						ecVolume = value;
					}
				}

				public string BenignVolume
				{
					get
					{
						return benignVolume;
					}
					set	
					{
						benignVolume = value;
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

				public List<string> Possibilities
				{
					get
					{
						return possibilities;
					}
					set	
					{
						possibilities = value;
					}
				}
			}
		}
	}
}

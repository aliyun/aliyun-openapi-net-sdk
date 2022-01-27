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

namespace Aliyun.Acs.LinkWAN.Model.V20190301
{
	public class ListTransferPacketResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private ListTransferPacket_Data data;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public ListTransferPacket_Data Data
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

		public class ListTransferPacket_Data
		{

			private long? totalCount;

			private List<ListTransferPacket_Packet> list;

			public long? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public List<ListTransferPacket_Packet> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListTransferPacket_Packet
			{

				private string gwEui;

				private string devEui;

				private string devAddr;

				private float? freq;

				private string datr;

				private string classMode;

				private int? rssi;

				private float? lsnr;

				private int? fPort;

				private long? freqBandPlanGroupId;

				private long? logMillis;

				private bool? hasMacCommand;

				private bool? hasData;

				private string base64EncodedMacPayload;

				private long? macPayloadSize;

				private string processEvent;

				private string messageType;

				private long? fcntDown;

				private long? fcntUp;

				public string GwEui
				{
					get
					{
						return gwEui;
					}
					set	
					{
						gwEui = value;
					}
				}

				public string DevEui
				{
					get
					{
						return devEui;
					}
					set	
					{
						devEui = value;
					}
				}

				public string DevAddr
				{
					get
					{
						return devAddr;
					}
					set	
					{
						devAddr = value;
					}
				}

				public float? Freq
				{
					get
					{
						return freq;
					}
					set	
					{
						freq = value;
					}
				}

				public string Datr
				{
					get
					{
						return datr;
					}
					set	
					{
						datr = value;
					}
				}

				public string ClassMode
				{
					get
					{
						return classMode;
					}
					set	
					{
						classMode = value;
					}
				}

				public int? Rssi
				{
					get
					{
						return rssi;
					}
					set	
					{
						rssi = value;
					}
				}

				public float? Lsnr
				{
					get
					{
						return lsnr;
					}
					set	
					{
						lsnr = value;
					}
				}

				public int? FPort
				{
					get
					{
						return fPort;
					}
					set	
					{
						fPort = value;
					}
				}

				public long? FreqBandPlanGroupId
				{
					get
					{
						return freqBandPlanGroupId;
					}
					set	
					{
						freqBandPlanGroupId = value;
					}
				}

				public long? LogMillis
				{
					get
					{
						return logMillis;
					}
					set	
					{
						logMillis = value;
					}
				}

				public bool? HasMacCommand
				{
					get
					{
						return hasMacCommand;
					}
					set	
					{
						hasMacCommand = value;
					}
				}

				public bool? HasData
				{
					get
					{
						return hasData;
					}
					set	
					{
						hasData = value;
					}
				}

				public string Base64EncodedMacPayload
				{
					get
					{
						return base64EncodedMacPayload;
					}
					set	
					{
						base64EncodedMacPayload = value;
					}
				}

				public long? MacPayloadSize
				{
					get
					{
						return macPayloadSize;
					}
					set	
					{
						macPayloadSize = value;
					}
				}

				public string ProcessEvent
				{
					get
					{
						return processEvent;
					}
					set	
					{
						processEvent = value;
					}
				}

				public string MessageType
				{
					get
					{
						return messageType;
					}
					set	
					{
						messageType = value;
					}
				}

				public long? FcntDown
				{
					get
					{
						return fcntDown;
					}
					set	
					{
						fcntDown = value;
					}
				}

				public long? FcntUp
				{
					get
					{
						return fcntUp;
					}
					set	
					{
						fcntUp = value;
					}
				}
			}
		}
	}
}

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
	public class ListGatewayTransferPacketsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private ListGatewayTransferPackets_Data data;

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

		public ListGatewayTransferPackets_Data Data
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

		public class ListGatewayTransferPackets_Data
		{

			private long? totalCount;

			private List<ListGatewayTransferPackets_Packet> list;

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

			public List<ListGatewayTransferPackets_Packet> List
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

			public class ListGatewayTransferPackets_Packet
			{

				private string gwEui;

				private string devEui;

				private string logMillis;

				private string devAddr;

				private string freq;

				private string datr;

				private string classMode;

				private int? rssi;

				private float? lsnr;

				private int? fPort;

				private bool? hasMacCommand;

				private bool? hasData;

				private string base64EncodedMacPayload;

				private long? macPayloadSize;

				private string processEvent;

				private string messageType;

				private string nodeOwnerAliyunId;

				private List<Dictionary<string, string>> macCommandCIDs;

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

				public string LogMillis
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

				public string Freq
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

				public string NodeOwnerAliyunId
				{
					get
					{
						return nodeOwnerAliyunId;
					}
					set	
					{
						nodeOwnerAliyunId = value;
					}
				}

				public List<Dictionary<string, string>> MacCommandCIDs
				{
					get
					{
						return macCommandCIDs;
					}
					set	
					{
						macCommandCIDs = value;
					}
				}
			}
		}
	}
}

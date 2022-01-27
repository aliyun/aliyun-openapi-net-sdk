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
	public class ListNodeTransferPacketsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private ListNodeTransferPackets_Data data;

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

		public ListNodeTransferPackets_Data Data
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

		public class ListNodeTransferPackets_Data
		{

			private long? totalCount;

			private List<ListNodeTransferPackets_Packet> list;

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

			public List<ListNodeTransferPackets_Packet> List
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

			public class ListNodeTransferPackets_Packet
			{

				private string gwEui;

				private string devEui;

				private float? freq;

				private string datr;

				private string classMode;

				private int? rssi;

				private float? snr;

				private long? logMillis;

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

				public float? Snr
				{
					get
					{
						return snr;
					}
					set	
					{
						snr = value;
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
			}
		}
	}
}

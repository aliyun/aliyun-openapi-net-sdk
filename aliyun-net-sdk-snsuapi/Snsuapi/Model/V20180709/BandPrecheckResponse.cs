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

namespace Aliyun.Acs.Snsuapi.Model.V20180709
{
	public class BandPrecheckResponse : AcsResponse
	{

		private string requestId;

		private string resultCode;

		private string resultMessage;

		private BandPrecheck_ResultModule resultModule;

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

		public string ResultCode
		{
			get
			{
				return resultCode;
			}
			set	
			{
				resultCode = value;
			}
		}

		public string ResultMessage
		{
			get
			{
				return resultMessage;
			}
			set	
			{
				resultMessage = value;
			}
		}

		public BandPrecheck_ResultModule ResultModule
		{
			get
			{
				return resultModule;
			}
			set	
			{
				resultModule = value;
			}
		}

		public class BandPrecheck_ResultModule
		{

			private long? bandId;

			private int? uploadBandwidth;

			private int? downloadBandwidth;

			private List<BandPrecheck_BandOfferListItem> bandOfferList;

			public long? BandId
			{
				get
				{
					return bandId;
				}
				set	
				{
					bandId = value;
				}
			}

			public int? UploadBandwidth
			{
				get
				{
					return uploadBandwidth;
				}
				set	
				{
					uploadBandwidth = value;
				}
			}

			public int? DownloadBandwidth
			{
				get
				{
					return downloadBandwidth;
				}
				set	
				{
					downloadBandwidth = value;
				}
			}

			public List<BandPrecheck_BandOfferListItem> BandOfferList
			{
				get
				{
					return bandOfferList;
				}
				set	
				{
					bandOfferList = value;
				}
			}

			public class BandPrecheck_BandOfferListItem
			{

				private long? offerId;

				private int? bandwidth;

				private long? duration;

				private string direction;

				public long? OfferId
				{
					get
					{
						return offerId;
					}
					set	
					{
						offerId = value;
					}
				}

				public int? Bandwidth
				{
					get
					{
						return bandwidth;
					}
					set	
					{
						bandwidth = value;
					}
				}

				public long? Duration
				{
					get
					{
						return duration;
					}
					set	
					{
						duration = value;
					}
				}

				public string Direction
				{
					get
					{
						return direction;
					}
					set	
					{
						direction = value;
					}
				}
			}
		}
	}
}

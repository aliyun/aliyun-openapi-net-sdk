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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveDomainRecordDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveDomainRecordData_RecordDataInfo> recordDataInfos;

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

		public List<DescribeLiveDomainRecordData_RecordDataInfo> RecordDataInfos
		{
			get
			{
				return recordDataInfos;
			}
			set	
			{
				recordDataInfos = value;
			}
		}

		public class DescribeLiveDomainRecordData_RecordDataInfo
		{

			private string date;

			private int? total;

			private DescribeLiveDomainRecordData_Detail detail;

			public string Date
			{
				get
				{
					return date;
				}
				set	
				{
					date = value;
				}
			}

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public DescribeLiveDomainRecordData_Detail Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}

			public class DescribeLiveDomainRecordData_Detail
			{

				private int? mP4;

				private int? fLV;

				private int? tS;

				public int? MP4
				{
					get
					{
						return mP4;
					}
					set	
					{
						mP4 = value;
					}
				}

				public int? FLV
				{
					get
					{
						return fLV;
					}
					set	
					{
						fLV = value;
					}
				}

				public int? TS
				{
					get
					{
						return tS;
					}
					set	
					{
						tS = value;
					}
				}
			}
		}
	}
}

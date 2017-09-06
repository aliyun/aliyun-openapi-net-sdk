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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveStreamTranscodeInfoResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo> domainTranscodeList;

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

		public List<DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo> DomainTranscodeList
		{
			get
			{
				return domainTranscodeList;
			}
			set	
			{
				domainTranscodeList = value;
			}
		}

		public class DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo
		{

			private string transcodeApp;

			private string transcodeName;

			private string transcodeTemplate;

			public string TranscodeApp
			{
				get
				{
					return transcodeApp;
				}
				set	
				{
					transcodeApp = value;
				}
			}

			public string TranscodeName
			{
				get
				{
					return transcodeName;
				}
				set	
				{
					transcodeName = value;
				}
			}

			public string TranscodeTemplate
			{
				get
				{
					return transcodeTemplate;
				}
				set	
				{
					transcodeTemplate = value;
				}
			}
		}
	}
}
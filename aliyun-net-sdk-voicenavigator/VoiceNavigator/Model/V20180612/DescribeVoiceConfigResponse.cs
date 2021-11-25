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

namespace Aliyun.Acs.VoiceNavigator.Model.V20180612
{
	public class DescribeVoiceConfigResponse : AcsResponse
	{

		private string speechNoiseThreshold;

		private string asrCustomizationId;

		private string voice;

		private string requestId;

		private string asrClassVocabularyId;

		private string asrVocabularyId;

		private string asrAcousticModelId;

		private int? volume;

		private int? speechRate;

		private List<DescribeVoiceConfig_Ip> apesIpList;

		public string SpeechNoiseThreshold
		{
			get
			{
				return speechNoiseThreshold;
			}
			set	
			{
				speechNoiseThreshold = value;
			}
		}

		public string AsrCustomizationId
		{
			get
			{
				return asrCustomizationId;
			}
			set	
			{
				asrCustomizationId = value;
			}
		}

		public string Voice
		{
			get
			{
				return voice;
			}
			set	
			{
				voice = value;
			}
		}

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

		public string AsrClassVocabularyId
		{
			get
			{
				return asrClassVocabularyId;
			}
			set	
			{
				asrClassVocabularyId = value;
			}
		}

		public string AsrVocabularyId
		{
			get
			{
				return asrVocabularyId;
			}
			set	
			{
				asrVocabularyId = value;
			}
		}

		public string AsrAcousticModelId
		{
			get
			{
				return asrAcousticModelId;
			}
			set	
			{
				asrAcousticModelId = value;
			}
		}

		public int? Volume
		{
			get
			{
				return volume;
			}
			set	
			{
				volume = value;
			}
		}

		public int? SpeechRate
		{
			get
			{
				return speechRate;
			}
			set	
			{
				speechRate = value;
			}
		}

		public List<DescribeVoiceConfig_Ip> ApesIpList
		{
			get
			{
				return apesIpList;
			}
			set	
			{
				apesIpList = value;
			}
		}

		public class DescribeVoiceConfig_Ip
		{

			private string ip;

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
				}
			}
		}
	}
}

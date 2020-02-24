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
	public class DescribeTTSConfigResponse : AcsResponse
	{

		private string requestId;

		private string voice;

		private int? speechRate;

		private int? volume;

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
	}
}

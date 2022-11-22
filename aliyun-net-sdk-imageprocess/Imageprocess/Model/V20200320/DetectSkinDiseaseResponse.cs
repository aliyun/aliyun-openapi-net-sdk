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
	public class DetectSkinDiseaseResponse : AcsResponse
	{

		private string requestId;

		private DetectSkinDisease_Data data;

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

		public DetectSkinDisease_Data Data
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

		public class DetectSkinDisease_Data
		{

			private string results;

			private string resultsEnglish;

			private string bodyPart;

			private float? imageQuality;

			private string imageType;

			public string Results
			{
				get
				{
					return results;
				}
				set	
				{
					results = value;
				}
			}

			public string ResultsEnglish
			{
				get
				{
					return resultsEnglish;
				}
				set	
				{
					resultsEnglish = value;
				}
			}

			public string BodyPart
			{
				get
				{
					return bodyPart;
				}
				set	
				{
					bodyPart = value;
				}
			}

			public float? ImageQuality
			{
				get
				{
					return imageQuality;
				}
				set	
				{
					imageQuality = value;
				}
			}

			public string ImageType
			{
				get
				{
					return imageType;
				}
				set	
				{
					imageType = value;
				}
			}
		}
	}
}

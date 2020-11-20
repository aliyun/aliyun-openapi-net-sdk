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

namespace Aliyun.Acs.ocr.Model.V20191230
{
	public class RecognizePassportMRZResponse : AcsResponse
	{

		private string requestId;

		private RecognizePassportMRZ_Data data;

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

		public RecognizePassportMRZ_Data Data
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

		public class RecognizePassportMRZ_Data
		{

			private List<RecognizePassportMRZ_Region> regions;

			public List<RecognizePassportMRZ_Region> Regions
			{
				get
				{
					return regions;
				}
				set	
				{
					regions = value;
				}
			}

			public class RecognizePassportMRZ_Region
			{

				private string name;

				private float? recognitionScore;

				private string content;

				private float? detectionScore;

				private List<string> bandBoxes;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public float? RecognitionScore
				{
					get
					{
						return recognitionScore;
					}
					set	
					{
						recognitionScore = value;
					}
				}

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}

				public float? DetectionScore
				{
					get
					{
						return detectionScore;
					}
					set	
					{
						detectionScore = value;
					}
				}

				public List<string> BandBoxes
				{
					get
					{
						return bandBoxes;
					}
					set	
					{
						bandBoxes = value;
					}
				}
			}
		}
	}
}

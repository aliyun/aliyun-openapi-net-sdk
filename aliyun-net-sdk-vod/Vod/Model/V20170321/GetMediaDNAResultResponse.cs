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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetMediaDNAResultResponse : AcsResponse
	{

		private string requestId;

		private GetMediaDNAResult_DNAResult dNAResult;

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

		public GetMediaDNAResult_DNAResult DNAResult
		{
			get
			{
				return dNAResult;
			}
			set	
			{
				dNAResult = value;
			}
		}

		public class GetMediaDNAResult_DNAResult
		{

			private List<GetMediaDNAResult_VideoDNAItem> videoDNA;

			public List<GetMediaDNAResult_VideoDNAItem> VideoDNA
			{
				get
				{
					return videoDNA;
				}
				set	
				{
					videoDNA = value;
				}
			}

			public class GetMediaDNAResult_VideoDNAItem
			{

				private string primaryKey;

				private string similarity;

				private List<GetMediaDNAResult_DetailItem> detail;

				public string PrimaryKey
				{
					get
					{
						return primaryKey;
					}
					set	
					{
						primaryKey = value;
					}
				}

				public string Similarity
				{
					get
					{
						return similarity;
					}
					set	
					{
						similarity = value;
					}
				}

				public List<GetMediaDNAResult_DetailItem> Detail
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

				public class GetMediaDNAResult_DetailItem
				{

					private GetMediaDNAResult_Input input;

					private GetMediaDNAResult_Duplication duplication;

					public GetMediaDNAResult_Input Input
					{
						get
						{
							return input;
						}
						set	
						{
							input = value;
						}
					}

					public GetMediaDNAResult_Duplication Duplication
					{
						get
						{
							return duplication;
						}
						set	
						{
							duplication = value;
						}
					}

					public class GetMediaDNAResult_Input
					{

						private string start;

						private string duration;

						public string Start
						{
							get
							{
								return start;
							}
							set	
							{
								start = value;
							}
						}

						public string Duration
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
					}

					public class GetMediaDNAResult_Duplication
					{

						private string start;

						private string duration;

						public string Start
						{
							get
							{
								return start;
							}
							set	
							{
								start = value;
							}
						}

						public string Duration
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
					}
				}
			}
		}
	}
}

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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeGlobalDataNetworkListResponse : AcsResponse
	{

		private string requestId;

		private string totalRecordCount;

		private string pageRecordCount;

		private string pageNumber;

		private string nextToken;

		private int? maxResults;

		private DescribeGlobalDataNetworkList_Items items;

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

		public string TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		public string PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		public string PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public DescribeGlobalDataNetworkList_Items Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeGlobalDataNetworkList_Items
		{

			private List<DescribeGlobalDataNetworkList_Network> networks;

			public List<DescribeGlobalDataNetworkList_Network> Networks
			{
				get
				{
					return networks;
				}
				set	
				{
					networks = value;
				}
			}

			public class DescribeGlobalDataNetworkList_Network
			{

				private string networkId;

				private string networkDescription;

				private string networkStatus;

				private string createTime;

				private List<DescribeGlobalDataNetworkList_Channel> channels;

				private DescribeGlobalDataNetworkList_NetworkTopology networkTopology;

				public string NetworkId
				{
					get
					{
						return networkId;
					}
					set	
					{
						networkId = value;
					}
				}

				public string NetworkDescription
				{
					get
					{
						return networkDescription;
					}
					set	
					{
						networkDescription = value;
					}
				}

				public string NetworkStatus
				{
					get
					{
						return networkStatus;
					}
					set	
					{
						networkStatus = value;
					}
				}

				public string CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}

				public List<DescribeGlobalDataNetworkList_Channel> Channels
				{
					get
					{
						return channels;
					}
					set	
					{
						channels = value;
					}
				}

				public DescribeGlobalDataNetworkList_NetworkTopology NetworkTopology
				{
					get
					{
						return networkTopology;
					}
					set	
					{
						networkTopology = value;
					}
				}

				public class DescribeGlobalDataNetworkList_Channel
				{

					private string channelId;

					private string channelStatus;

					private string progress;

					private bool? freezeSourceDuringSync;

					public string ChannelId
					{
						get
						{
							return channelId;
						}
						set	
						{
							channelId = value;
						}
					}

					public string ChannelStatus
					{
						get
						{
							return channelStatus;
						}
						set	
						{
							channelStatus = value;
						}
					}

					public string Progress
					{
						get
						{
							return progress;
						}
						set	
						{
							progress = value;
						}
					}

					public bool? FreezeSourceDuringSync
					{
						get
						{
							return freezeSourceDuringSync;
						}
						set	
						{
							freezeSourceDuringSync = value;
						}
					}
				}

				public class DescribeGlobalDataNetworkList_NetworkTopology
				{

					private List<DescribeGlobalDataNetworkList_Source> sources;

					private List<DescribeGlobalDataNetworkList_Destination> destinations;

					public List<DescribeGlobalDataNetworkList_Source> Sources
					{
						get
						{
							return sources;
						}
						set	
						{
							sources = value;
						}
					}

					public List<DescribeGlobalDataNetworkList_Destination> Destinations
					{
						get
						{
							return destinations;
						}
						set	
						{
							destinations = value;
						}
					}

					public class DescribeGlobalDataNetworkList_Source
					{

						private string sourceFileSystemPath;

						private string sourceType;

						private string sourceRegion;

						private string sourceId;

						public string SourceFileSystemPath
						{
							get
							{
								return sourceFileSystemPath;
							}
							set	
							{
								sourceFileSystemPath = value;
							}
						}

						public string SourceType
						{
							get
							{
								return sourceType;
							}
							set	
							{
								sourceType = value;
							}
						}

						public string SourceRegion
						{
							get
							{
								return sourceRegion;
							}
							set	
							{
								sourceRegion = value;
							}
						}

						public string SourceId
						{
							get
							{
								return sourceId;
							}
							set	
							{
								sourceId = value;
							}
						}
					}

					public class DescribeGlobalDataNetworkList_Destination
					{

						private string destinationFileSystemPath;

						private string destinationRegion;

						private string destinationType;

						private string destinationId;

						public string DestinationFileSystemPath
						{
							get
							{
								return destinationFileSystemPath;
							}
							set	
							{
								destinationFileSystemPath = value;
							}
						}

						public string DestinationRegion
						{
							get
							{
								return destinationRegion;
							}
							set	
							{
								destinationRegion = value;
							}
						}

						public string DestinationType
						{
							get
							{
								return destinationType;
							}
							set	
							{
								destinationType = value;
							}
						}

						public string DestinationId
						{
							get
							{
								return destinationId;
							}
							set	
							{
								destinationId = value;
							}
						}
					}
				}
			}
		}
	}
}
